using HrManagement.MVC.Contracts;
using System.Net.Http.Headers;

namespace HrManagement.MVC.Services.Base
{
    public class BaseHttpService
    {
        protected readonly ILocalStorageService _storage;
        protected readonly IClient _client;

        public BaseHttpService(IClient client, ILocalStorageService storage)
        {
            _storage = storage;
            _client = client;
        }
        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException exception)
        {
            if (exception.StatusCode == 400)
            {
                return new Response<Guid> { Messange = "Validation Error", ValidationError = exception.Response, Success = false };
            }
            else if (exception.StatusCode ==404) 
            {
                return new Response<Guid> { Messange = "Validation Error", Success = false };

            }
            else
            {
                return new Response<Guid> { Messange = "Something is Wrong", Success = false };

            }

        }

        protected void AddBearerToken()
        {
            if (_storage.Exists("token"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _storage.GetStorageValue<string>("token"));
            }
        }
    }
}
