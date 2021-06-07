using System;
using System.Collections.Generic;
using System.Text;

namespace Common.SeedWork
{
    public class ResponseError
    {
        public string Message { get; set; }
    }
        public interface IResponse
        {
            public IEnumerable<ResponseError> Errors { get; set; }

        }
        public interface IResponse<TModel> : IResponse
        {
            public IEnumerable<TModel> Models {get;set;}
        }
    
}
