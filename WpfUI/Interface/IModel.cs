using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfUI.Interface
{
    public interface IModel
    {
        /// <summary>
        /// 关联数据上下文
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="viewModel"></param>
        void BindViewModel<TViewModel>(TViewModel viewModel);

        /// <summary>
        /// 关联默认数据上下文
        /// </summary>
        void BindDefaultModel();

        /// <summary>
        /// 获取主窗口
        /// </summary>
        /// <returns></returns>
        UserControl GetView();
    }
}
