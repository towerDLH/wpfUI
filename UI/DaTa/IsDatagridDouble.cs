using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UI.DaTa
{
    public class IsDatagridDouble
    {
        public bool IsPostion(DataGrid dtg, System.Windows.Input.MouseButtonEventArgs e)
        {
            Point aP = e.GetPosition(dtg);
            IInputElement obj = dtg.InputHitTest(aP);
            DependencyObject target = obj as DependencyObject;
            bool rowhit = false;
            while (target != null)
            {
                if (target is DataGridRow)
                {
                    rowhit = true;
                    break;
                }
                target = VisualTreeHelper.GetParent(target);
            }
            return rowhit;
        }

    }
}
