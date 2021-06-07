using MediatR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.SeedWork
{
    public class Locator : ILocator
    {
        private readonly ILogger<Locator> logger;
        private readonly IMediator mediator;
        private readonly LocatorTypeInfoProvider locatorTypeInfoProvider;

        public Locator(ILogger<Locator> logger, IMediator mediator, LocatorTypeInfoProvider locatorTypeInfoProvider)
        {
            this.logger = logger;
            this.mediator = mediator;
            this.locatorTypeInfoProvider = locatorTypeInfoProvider;
        }

        public async Task<string> Handle(Guid requestId, string type, string request)
        {
            logger.LogTrace("New Request",requestId,type, request);
            try
            {
                Type handler = typeof(SeedWork.Handler);
                Type[] types = locatorTypeInfoProvider.GetTypeInfos().ToArray();
                Type handlerContainer = types.Single(t => t.Name.ToLower() == type.ToLower());
                Type handlerRequestType = handlerContainer.GetNestedType("Request");
                Type handlerResponseType = handlerContainer.GetNestedType("Response");
                Type[] generics = { handlerRequestType, handlerResponseType };
                //generics should be the request,response;
                MethodInfo mi = this.GetType().GetMethod("GenericHandle").MakeGenericMethod(generics);
                Object[] parameters = new[] { JsonConvert.DeserializeObject(request, handlerRequestType) };
                return JsonConvert.SerializeObject(await (Task<IResponse>)mi.Invoke(this, parameters));
            }
            catch (Exception ex)
            {
                logger.LogError($"{request.ToString()} failed.",ex);
                return "{\"Errors\":[{\"Message\":\"Your request could not be processed at this time.\"}] }";
            }
        }
        async public Task<IResponse> GenericHandle<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>
        {
            return (IResponse)await mediator.Send<TResponse>(request);
        }
    }
}