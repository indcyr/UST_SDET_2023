using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_work.ExceptionMessages
{
    internal class MyExceptions
    {
        /* public static List<string> exmesslist = new List<string>()
         {
          "Dont give 0 for Denom",
          "Index is out of Range",
          "Unknown Exception"
         }; */
        public static Dictionary<string, string> exmesslist = new Dictionary<string, string>();
        public MyExceptions()
        {
            exmesslist.Add("Div", "Don't give 0 for denominator");
            exmesslist.Add("I", "Index is out of range");
            exmesslist.Add("U", "Unknown Exception");
        }
    }
}