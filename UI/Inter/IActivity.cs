using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Inter
{
    interface IActivity
    {
        double X { get; set; }
        double Y { get; set; }
        string type { get; set; }
        string title { get; set; }
        List<string> branchList { get; set; }
        void Del();
        IDesigner Designer { get; set; }
        void SetActive();
        string Dsc { get; set; }

        object NodeDate { set; get; }
    }
}
