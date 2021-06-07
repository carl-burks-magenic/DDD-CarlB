using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.SeedWork
{
    public interface ILocator
    {
        public Task<string> Handle(
                Guid requestId,
                string type,
                string request
            );
    }
}
