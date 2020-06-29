using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DiagramDesigner.Model
{
    public class FlowChar
    {

        private string flowname;
        /// <summary>
        /// 子流程名称
        /// </summary>
        public string Flowname
        {
            get { return flowname; }
            set { flowname = value; }
        }

        private string icoImage;
        /// <summary>
        /// 图片路径
        /// </summary>
        public string IcoImage
        {
            get { return icoImage; }
            set { icoImage = value; }
        }

        private string flowcharpath;
        /// <summary>
        /// 子控件路径
        /// </summary>
        public string FlowcharPath
        {
            get { return flowcharpath; }
            set { flowcharpath = value; }
        }


    }
}
