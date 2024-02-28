using AutoMapper;
using Hr_Management.Application.Contracts.Persistence;
using Hr_Management.Application.DTOs.Type;
using Hr_Management.Application.features.LeaveTypes.Handlers.Queries;
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

namespace Hr_Management.Application.UnitTests.LeaveTypes.Queries
{
    public class GetLeaveTypeListRequestHandlerTests
    {
        IMapper _mapper;
        Mock<ILeaveTypeRepository> _moqRepository;
        public GetLeaveTypeListRequestHandlerTests()
        {
            _moqRepository = MockLeaveRepository.GetLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();   
        }
        [Fact]
        public async Task GetLeaveListTest()
        {
            var handler = new GetLeaveTypeListRequestHander(_moqRepository.Object,_mapper);
            var result = await handler.Handle(new GetLeaveTypeListRequest() ,CancellationToken.None);

            result.ShouldBeOfType<List<LeaveTypeDto>>();
            result.Count.ShouldBe(2);
        }
    }
}
