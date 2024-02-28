using Hr_Management.Application.Contracts.Persistence;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr_Management.Application.UnitTests.Mocks
{
    public static class MockLeaveRepository
    {
        public static Mock<ILeaveTypeRepository> GetLeaveTypeRepository()
        {
            var leaveTypes = new List<LeaveType>()
            { 
                new LeaveType
                {
                 Id = 1,
                 DefaultDay = 10,
                 Name = "Test Vacation",
                },
            new LeaveType
                {
                 Id = 2,
                 DefaultDay = 20,    
                 Name = "Test Silk",
                }
            };

            var mocks = new Mock<ILeaveTypeRepository>();
            mocks.Setup(r => r.GetAll()).ReturnsAsync(leaveTypes);

            mocks.Setup(r => r.Add(It.IsAny<LeaveType>()))    
                .ReturnsAsync((LeaveType leaveType) =>
                {
                    leaveTypes.Add(leaveType);
                    return leaveType;
                });

            return mocks;
        }
    }
}
