using AutoMapper;
using FluentValidation;
using Hr_Management.Application.DTOs.Type.Validator;
using Hr_Management.Application.Exceptions;
using Hr_Management.Application.features.LeaveTypes.Requests.Commonds;
using Hr_Management.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Hr_Management.Application.Responses;
using FluentValidation.Results;
using System.Linq;

namespace Hr_Management.Application.features.LeaveTypes.Handlers.Commonds
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommands, BaseCommandResponse>
    {
        private readonly ILeaveTypeRepository _LeaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _LeaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateLeaveTypeCommands request, CancellationToken cancellationToken)
        {
            var respones = new BaseCommandResponse();
            var validator = new CreateLeaveTypeValidator();
            var validatorResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (validatorResult.IsValid == false)
            {
                //throw new ValidationsException(validatorResult);
                respones.Success = false;
                respones.Message = "Creation Failed";
                respones.Errors = validatorResult.Errors.Select(e => e.ErrorMessage).ToList();


            }
            else
            {
                var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
                leaveType = await _LeaveTypeRepository.Add(leaveType);
                respones.Success = true;
                respones.Message = "Creation Successful";
                respones.Id = leaveType.Id;
            }

            return respones;
        }
    }
}
