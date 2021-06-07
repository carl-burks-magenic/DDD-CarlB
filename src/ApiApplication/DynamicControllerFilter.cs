using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Linq;

namespace ApiApplication
{
    public class DynamicControllerFilter
    {
        private readonly GenericControllerNameGenerator genericControllerNameGenerator;

        public DynamicControllerFilter(GenericControllerNameGenerator genericControllerNameGenerator)
        {
            this.genericControllerNameGenerator = genericControllerNameGenerator;
        }
        public bool ShouldFilterController(Type type,  ControllerFeature controllerFeature)=>!controllerFeature.Controllers.Any(
                        existingController => this.genericControllerNameGenerator.CreateName(type) == existingController.Name
                        );
    }
}
