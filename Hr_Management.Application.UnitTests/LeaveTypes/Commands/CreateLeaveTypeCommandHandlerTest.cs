using AutoMapper;
using Hr_Management.Application.Contracts.Persistence;
using Hr_Management.Application.DTOs.Type;
using Hr_Management.Application.features.LeaveTypes.Handlers.Commonds;
using Hr_Management.Application.features.LeaveTypes.Handlers.Queries;
using Hr_Management.Application.features.LeaveTypes.Requests.Commonds;
using Hr_Management.Application.features.LeaveTypes.Requests.Queries;
using Hr_Management.Application.Profiles;
using Hr_Management.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Management.Application.UnitTests.LeaveTypes.Commands
{
    public class CreateLeaveTypeCommandHandlerTest
    {
        IMapper _mapper;
        Mock<ILeaveTypeRepository> _moqRepository;
        CreateLeaveTypeDto _leaveTypeDto;
        public CreateLeaveTypeCommandHandlerTest()
        {
            _moqRepository = MockLeaveRepository.GetLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _leaveTypeDto = new CreateLeaveTypeDto()
            {
                DefauletDay = 15,
                Name = "Test Dto",
            };
        }
        [Fact]
        public async Task CreateLeaveType()
        {
            var handler = new CreateLeaveTypeCommandHandler(_moqRepository.Object, _mapper);
            var result = await handler.Handle(new CreateLeaveTypeCommands() {LeaveTypeDto = _leaveTypeDto }, CancellationToken.None);
            result.ShouldBeOfType<int>();
            
            var leaveType = await _moqRepository.Object.GetAll();
            leaveType.Count.ShouldBe(3);
        }
    }
}   
