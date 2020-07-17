using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Eumn;

namespace UI.Model
{
    public class ResourcesClass
    {

        private static int english=(int)StudentEnum.英语;

        public static int English
        {
            get { return english; }
            set { english = value; }
        }

        public static int TestEnglish= (int)StudentEnum.英语;

    }
}
