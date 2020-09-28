using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UI.Interface
{
    public interface IAutoFacLocator
    {
        void Register(Assembly asb);

        TInterface Get<TInterface>();

        TInterface Get<TInterface>(string typeName);

    }
}
