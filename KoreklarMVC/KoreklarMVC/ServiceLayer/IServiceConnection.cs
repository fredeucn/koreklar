﻿namespace KoreklarMVC.ServiceLayer
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

