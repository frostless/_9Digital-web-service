using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9Digital_web_service.Interfaces
{
    public interface IFilterable<T>
    {
        T Filter();
    }
}
