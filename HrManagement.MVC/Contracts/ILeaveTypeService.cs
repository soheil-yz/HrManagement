using HrManagement.MVC.Models;
using HrManagement.MVC.Services.Base;

namespace HrManagement.MVC.Contracts
{
    public interface ILeaveTypeService
    {
        Task<List<LeaveTypeViewModel>> GetLeaveTypes();
        Task<LeaveTypeViewModel> GetLeaveTypeDetails(int id);
        Task<Response<int>> CreateLeaveType(LeaveTypeViewModel leaveType);
        Task UpdateLeaveType(LeaveTypeViewModel leaveType);
        Task DeleteLeaveType(LeaveTypeViewModel leaveType);
    }
}
