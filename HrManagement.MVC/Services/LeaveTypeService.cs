using AutoMapper;
using HrManagement.MVC.Contracts;
using HrManagement.MVC.Models;
using HrManagement.MVC.Services.Base;
using System.Net.Http.Headers;

namespace HrManagement.MVC.Services
{
    public class LeaveTypeService : BaseHttpService, ILeaveTypeService
    {
        private readonly IMapper _mapper;
        private readonly IClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public LeaveTypeService(IMapper mapper,IClient httpClient,ILocalStorageService localStorageService)
            :base(httpClient ,localStorageService) 
        {
            _mapper = mapper;
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }
        public async Task<Response<int>> CreateLeaveType(LeaveTypeViewModel leaveType)
        {
            try
            {
                var response = new Response<int>();
                CreateLeaveTypeDto createLeaveTypeDto = _mapper.Map<CreateLeaveTypeDto>(leaveType);
                
                //ToDo Auth
                var apiResponse = await _client.LeaveTypePOSTAsync(createLeaveTypeDto);

                if (apiResponse.Success)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                else
                {
                    foreach (var err in apiResponse.Errors)
                    {
                        response.ValidationError +=  err + Environment.NewLine;
                    }
                }
                return response;
            }
            catch (ApiException ex) 
            {
            return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<Response<int>> DeleteLeaveType(int id)
        {
            try
            {
                await _client.LeaveTypeDELETEAsync(id);
                return new Response<int> { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<LeaveTypeViewModel> GetLeaveTypeDetails(int id)
        {
            var leaveType = await _client.LeaveTypeGETAsync(id);
            return _mapper.Map<LeaveTypeViewModel>(leaveType);
        }

        public async Task<List<LeaveTypeViewModel>> GetLeaveTypes()
        {
            var leaveTypes = await _client.LeaveTypeAllAsync();
            return _mapper.Map<List<LeaveTypeViewModel>>(leaveTypes);
        }

        public async Task<Response<int>> UpdateLeaveType(LeaveTypeViewModel leaveType , int id)
        {
            try
            {
                LeaveTypeDto leaveTypes = _mapper.Map<LeaveTypeDto>(leaveType);
                await _client.LeaveTypePUTAsync(id,leaveTypes);
                return new Response<int> { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }
    }
}
