using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiApplication
{
    [Microsoft.AspNetCore.Mvc.Route("api/v1/static/[controller]"), ApiController]
    public class HeartbeatController : ControllerBase
    {
        public class Heartbeat
        {
            public Heartbeat()
            {
                Id = System.Guid.NewGuid();
            }
            public Guid Id { get; private set; }
        }
        [Microsoft.AspNetCore.Mvc.HttpGet,Consumes("application/json")]
        async public Task<Heartbeat> Get()
        {
            return await Task.Run(()=> { return new Heartbeat(); });
        }
    }
}
