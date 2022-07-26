using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Base;
using UI.Common;
using UI.Interface;
using WpfUI.View;
using WpfUI.ViewModel;

namespace WpfUI.VIewDlg
{
    [Autofac(true)]
    public class CtlTreeDlg : BaseView<CtlTreeView, CtlTreeViewModel>, IModel
    {
    }
}
