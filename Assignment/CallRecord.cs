using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CallRecord
    {
        public CallRecord(int callId, double phoneNo, double callTime)
        {
            CallId = callId;
            PhoneNo = phoneNo;
            CallTime = callTime;
        }

        public int CallId { get; set; }

        public double PhoneNo { get; set; }

        public double CallTime { get; set;}

        public static Dictionary<int, CallRecord> calRec = new Dictionary<int, CallRecord>();

        public static void SearchRec(double phno)
        {
            foreach (var i in calRec.Values) 
            {
                if (phno == i.PhoneNo)
                {
                    Console.WriteLine("CallId :{0} \n CallTime: {1}", i.CallId,i.CallTime);
                }
            }
        }
        public static void TotalCalls()
        {
            Dictionary<double, int> totalcall = new Dictionary<double, int>();
            foreach (var i in calRec.Values)
            {
                if(totalcall.ContainsKey(i.PhoneNo))
                {
                    totalcall[i.PhoneNo]++;
                }
                else
                {
                    totalcall[i.PhoneNo] = 1;
                }


            }
            foreach(var i in totalcall)
            {
                Console.WriteLine("Phone Number : {0}\t Total calls: {1}", i.Key,i.Value);
            }
        }
    }
    
}
