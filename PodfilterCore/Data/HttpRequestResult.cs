﻿using System.Net.Http;

namespace PodfilterCore.Data
{
    public class HttpRequestResult<T>
    {
        public HttpResponseMessage ResponseMessage { get; private set; }
        public T Content { get; private set; }
        
        public HttpRequestResult(HttpResponseMessage response, T content)
        {
            this.ResponseMessage = response;
            this.Content = content;
        }
    }
}