using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    abstract class ServiceFactory
    {
        public abstract Service GetService();
    }
}
