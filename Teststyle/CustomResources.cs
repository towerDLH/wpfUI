using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Teststyle
{
    public class CustomResources
    {
        public static ComponentResourceKey DesertBrushKey
        {
            get
            {
                return new ComponentResourceKey(
                typeof(CustomResources), "DesertBrush");
            }
        }
    }
}
