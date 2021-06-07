using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ApiApplication
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class GenericControllerNameAttribute : Attribute, IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            //Limited DI support for Attributes so we use the new here
            GenericControllerNameGenerator controllerNameGenerator = new GenericControllerNameGenerator();

            if (controller.ControllerType.GetGenericTypeDefinition() == typeof(GenericController<,>))
            {
                Type requestType = controller.ControllerType.GenericTypeArguments[0];
                Type handlerType = requestType.DeclaringType;
                controller.ControllerName = controllerNameGenerator.CreateName(handlerType);
            }
        }
    }
}
