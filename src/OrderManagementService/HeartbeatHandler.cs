using Common.SeedWork;
using MediatR;
using System;
using System.Collections.Generic;

namespace OrderManagementService
{
    [Common.SeedWork.Handler()]
    public class HeartbeatService
    {
        public class Request: IRequest<Response>
        {

        }
        public class Model
        {
            public Guid Heartbeat { get; set; }
        }
        public class Response : IResponse<Model>
        {
            public IEnumerable<Model> Models { get;set; }
            public IEnumerable<ResponseError> Errors { get; set; }
        }
        public class Handler : RequestHandler<Request, Response>
        {
            protected override Response Handle(Request request)
            {

                return new Response() { Errors = { }, Models = new List<Model> { new Model() { Heartbeat=Guid.NewGuid()} } };
                
             }
        }
    }
}
