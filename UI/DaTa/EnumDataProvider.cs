using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UI.DaTa
{
    public class EnumDataProvider : ObjectDataProvider
    {
        private Type _type;
        public Type Type
        {
            get => _type;
            set
            {
                _type = value;
                MethodName = "GetValues";
                ObjectType = typeof(System.Enum);
                MethodParameters.Add(value);
            }
        }

       
    }
}
