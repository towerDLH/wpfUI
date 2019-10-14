using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
   public  class Calculator
    {

        

            public double Add(double one, double two)

            {

                return one + two;

            }



            public string Add(string arg1, string arg2)

            {

                int x = 0;

                int y = 0;

                if (int.TryParse(arg1, out x) && int.TryParse(arg2, out y))

                {

                    return this.Add(x, y).ToString();

                }

                else

                {

                    return "Input Error!";

                }

            }
 
    }
}
