using AutoMapper;
using Hr_Management.Application.DTOs.Request.Validator;
using Hr_Management.Application.DTOs.Type.Validator;
using Hr_Management.Application.Exceptions;
using Hr_Management.Application.features.LeaveRequests.Requests.Commonds;
using Hr_Management.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Hr_Management.Application.Contracts.Infrastructure;
using Hr_Management.Application.Responses;
using FluentValidation.Results;
using System.Linq;
using Hr_Management.Application.Models;

namespace Hr_Management.Application.features.LeaveRequests.Handlers.Commonds
{
    public class CreateLeaveRequestsCommandHandler : IRequestHandler<CreateLeaveRequestsCommand, BaseCommandResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public readonly ILeaveTypeRepository _LeaveTypeRepository;
        private readonly IEmailSender _emailSender;

        public CreateLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper,
            ILeaveTypeRepository leaveTypeRepository, IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            _LeaveTypeRepository = leaveTypeRepository;
            _emailSender = emailSender;
        }


        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestsCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveRequestDtoValidator(_LeaveTypeRepository);
            var validatorResult = await validator.ValidateAsync(request.LeaveRequestDto);

            if (validatorResult.IsValid == false)
            {
                //throw new ValidationsException(validatorResult);
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validatorResult.Errors.Select(q => q.ErrorMessage).ToList();
            }


            var leaveRequest = _mapper.Map<Hr_Management.LeaveRequest>(request.LeaveRequestDto);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);

            response.Success = true;
            response.Message = "Creation Succesdsful";
            response.Id = leaveRequest.Id;

            var email = new Email
            {
                To = "Soheil@gmail.com",
                Subject = "Leave Request Submitted",
                Body = $"Your leave request for {request.LeaveRequestDto.StartDate} " +
                    $"to {request.LeaveRequestDto.EndDate} " +
                    $"has been submitted"
            };
            try
            {
                await _emailSender.SenderEmail(email);
            }
            catch (Exception ex)
            {
                //log
            }
            return response;
        }
    }
}
