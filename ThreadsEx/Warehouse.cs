using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsEx
{
    internal class Warehouse
    {
        private int boxCount = 0;

        public void AddBox(int workerId)
        {
            for (int i = 0; i <=5; i++) 
            {
                Thread.Sleep(2000);
                boxCount++;
                Console.WriteLine($"Worker {workerId} added a box . Total boxes : {boxCount}");
            }
            
        }
        public int GetBoxCount()
        {
            return boxCount;
        }

    }
}
