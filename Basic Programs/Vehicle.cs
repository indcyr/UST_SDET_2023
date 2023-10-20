using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal abstract class Vehicle
    {
        public int vehnum { get; set; }
        public string? Brand { get; set; }
        public string? model { get; set; }
        public string? type { get; set; }

        public abstract string? setTypeForVeh();

        public void Disp()
        {
            Console.WriteLine(vehnum + " " + Brand + " " + model);
        }
        
    
    }
}
