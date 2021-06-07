using System;

namespace ApiApplication
{
    public class GenericControllerNameGenerator
    {
        public string CreateName(Type t)
        {
            return $"{t.Name}";
        }
    }
}
