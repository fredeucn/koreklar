using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreklarFORMS.Services
{
    public class ServiceConnection : IServiceConnection
    {
        public ServiceConnection(string? inBaseUrl)
        {
            HttpEnabler = new HttpClient();
            BaseUrl = inBaseUrl;
            UseUrl = BaseUrl;
        }

        public HttpClient HttpEnabler { private get; init; }
        public string? BaseUrl { get; init; }
        public string? UseUrl { get; set; }

        public async Task<HttpResponseMessage?> CallServiceGet()
        {
            HttpResponseMessage? hrm = null;
            if (UseUrl != null)
            {
                hrm = await HttpEnabler.GetAsync(UseUrl);
            }
            return hrm;
        }

        async void IServiceConnection.CallServicePost(StringContent postJson)
        {
            if (UseUrl != null)
            {
                await HttpEnabler.PostAsync(UseUrl + "/create", postJson);
                System.Diagnostics.Debug.WriteLine("ServiceConnection Check");
            }
        }

        Task<HttpResponseMessage?> IServiceConnection.CallServicePut(StringContent postJson)
        {
            throw new NotImplementedException();
        }

        Task<HttpResponseMessage?> IServiceConnection.CallServiceDelete()
        {
            throw new NotImplementedException();
        }
    }
}
