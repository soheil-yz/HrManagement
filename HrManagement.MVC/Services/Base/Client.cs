
using System.Net.Http;

namespace HrManagement.MVC.Services.Base
{
    public partial class Client : IClient
    {
        // public HttpClient HttpClient { get { return _httpClient; }}
        public HttpClient HttpClient { get { return _httpClient; }}
    }
}
