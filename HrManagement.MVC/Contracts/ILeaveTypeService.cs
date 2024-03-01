using HrManagement.MVC.Models;
using HrManagement.MVC.Services.Base;

namespace HrManagement.MVC.Contracts
{
    public interface ILeaveTypeService
    {
        Task<List<LeaveTypeViewModel>> GetLeaveTypes();
        Task<LeaveTypeViewModel> GetLeaveTypeDetails(int id);
        Task<Response<int>> CreateLeaveType(LeaveTypeViewModel leaveType);
        Task<Response<int>> UpdateLeaveType(LeaveTypeViewModel leaveType , int id);
        Task<Response<int>> DeleteLeaveType(int id);
    }
}
