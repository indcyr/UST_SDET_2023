using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    class Electricity
    {
        public int consumernumber, prevreading, currreading;
        public string? consumername;

        public Electricity(int consumernumber, int prevreading, int currreading, string? consumername)
        {
            this.consumernumber = consumernumber;
            this.prevreading = prevreading;
            this.currreading = currreading;
            this.consumername = consumername;
        }

        /*public Electricity()
       {
           consumernumber = 12345;
           prevreading = 9000;
           currreading = 9300;
           consumername = "XX";
       }
        */
        public double CalculateBill()
        {
            double billamount = 0;
            int reading = currreading - prevreading;
            if(reading <= 100) 
            {
             billamount = reading * 2.00;
            }
            else if(reading <= 201 && reading >=101) 
            {
                billamount = (100 * 2) + ((reading-100) * 2.5);
            }
            else if(reading <= 401 && reading >=201)
            {
                billamount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
            }
            else
            {
                billamount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 4.5);
            }
            return billamount;
        }
    }
}
