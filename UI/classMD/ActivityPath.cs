using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace UI.classMD
{
    public class ActivityPath
    {
        public string Name
        {
            get { return Connection.Name; }
        }

        public string startpoint
        { set; get; }

        public string target
        { set; get; }

        public string Desc
        { set; get; }

        public string route
        { set; get; }

        public Path Connection
        { set; get; }

        public TextBlock Tebk
        { set; get; }


    }
}
