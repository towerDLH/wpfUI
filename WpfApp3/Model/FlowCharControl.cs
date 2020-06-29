using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Model
{
    [Serializable]
    public class FlowCharControl
    {

        private string filename;

        public string FileName
        {
            get { return filename; }
            set { filename = value; }
        }

        private string filepath;

        public string FilePath
        {
            get { return filepath; }
            set { filepath = value; }
        }

    }
}
