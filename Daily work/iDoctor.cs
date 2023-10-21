using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_work
{
    internal interface iDoctor
    {
        void AddNewDoctor(int Did, string? DNmae);
        void ModifyNewDoctor(int Did, string? DNmae);
        
    }
}
