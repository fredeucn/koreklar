using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koreklarFORMS.Services
{
    public interface IServiceConnection
    {

        public string? BaseUrl { get; init; }
        public string? UseUrl { get; set; }

        Task<HttpResponseMessage?> CallServiceGet();
        void CallServicePost(StringContent postJson);
        Task<HttpResponseMessage?> CallServicePut(StringContent postJson);
        Task<HttpResponseMessage?> CallServiceDelete();

    }
}
