using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ApiApplication
{
    //https://www.ben-morris.com/generic-controllers-in-asp-net-core/
    public class GenericControllerFeatureProvider: IApplicationFeatureProvider<ControllerFeature>
    {
        private readonly IEnumerable<TypeInfo> types;
        private readonly DynamicControllerFilter dynamicControllerFilter;

        public GenericControllerFeatureProvider(IEnumerable<TypeInfo> types,  DynamicControllerFilter dynamicControllerFilter)
        {
            this.types = types;
            this.dynamicControllerFilter = dynamicControllerFilter;
        }

        private void AddControllerFromTypeInfo(TypeInfo typeInfo, ControllerFeature feature)
        {
            Type containerType = typeInfo.AsType();
            Type requestType = containerType.GetNestedType("Request");
            Type responseType = containerType.GetNestedType("Response");
            Type genericController = typeof(GenericController<,>);
            feature.Controllers.Add(genericController.MakeGenericType(requestType, responseType).GetTypeInfo());

        }
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            Func<TypeInfo,bool> ShouldFilterController = (type) => this.dynamicControllerFilter.ShouldFilterController(type, feature);
            foreach (TypeInfo typeInfo in types.Where(ShouldFilterController))
            {
                Console.WriteLine($"{typeInfo.Name} should be loaded.");
                AddControllerFromTypeInfo(typeInfo,feature );
            }
        }
    }
}
