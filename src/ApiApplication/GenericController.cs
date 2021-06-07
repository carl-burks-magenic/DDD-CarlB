using Common.SeedWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApplication
{
    [Route("api/v1/[controller]"),GenericControllerNameAttribute]
    public class GenericController<TRequest,TResponse>
    {
        private ILogger<GenericController<TRequest, TResponse>> logger;
        private readonly ILocator locator;
        private readonly IHttpContextAccessor httpContextAccessor;

        public GenericController(ILogger<GenericController<TRequest,TResponse>> logger, ILocator locator, IHttpContextAccessor httpContextAccessor)
        {
            this.logger = logger;
            this.locator = locator;
            this.httpContextAccessor = httpContextAccessor;
        }
        [HttpPost, Consumes("application/json")]
        async public Task<TResponse> Post([FromBody]TRequest request)
        {
            Guid RequestId = System.Guid.NewGuid();
            httpContextAccessor.HttpContext.TraceIdentifier = RequestId.ToString();
            return JsonConvert.DeserializeObject<TResponse>(await locator.Handle(RequestId, request.GetType().DeclaringType.Name, JsonConvert.SerializeObject(request)));
        }
    }
}
