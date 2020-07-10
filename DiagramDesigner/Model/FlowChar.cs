using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace DiagramDesigner.Model
{
    [Serializable]
    public class FlowChar : ObservableObject
    {

        private string flowname;
        /// <summary>
        /// 流程名称
        /// </summary>
        public string Flowname
        {
            get { return flowname; }
            set { flowname = value; SetPerty("Flowname"); }
        }

        private string icoImage;
        /// <summary>
        /// 图片路径
        /// </summary>
        public string IcoImage
        {
            get { return icoImage; }
            set { icoImage = value; SetPerty("IcoImage"); }
        }

        private string flowcharpath;
        /// <summary>
        /// 子控件路径
        /// </summary>
        public string FlowcharPath
        {
            get { return flowcharpath; }
            set { flowcharpath = value; SetPerty("FlowcharPath"); }
        }

        private int flowtype;

        /// <summary>
        /// 流程类型，0为主流程，1为子流程
        /// </summary>
        public int Flowtype
        {
            get { return flowtype; }
            set { flowtype = value; SetPerty("Flowtype"); }
        }
        private ObservableCollection<XElement> listxs;
        /// <summary>
        /// 文件流程布局
        /// </summary>
        public ObservableCollection<XElement> Listxs
        {
            get { return listxs; }
            set { listxs = value; SetPerty("Listxs"); }
        }


    }
}
