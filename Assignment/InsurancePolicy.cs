using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class InsurancePolicy
    {
        public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? PolicyName { get; set; }
        public int PolicyId { get; set; }
        public double PremiumAmount { get; set; }

        public void RenewPolicy(double newPremium)
        {
            PremiumAmount = newPremium;
            Console.WriteLine("Policy Name : {0} \n Policy Id : {1} \n Updated Premium amount: {2}" ,PolicyName, PolicyId, PremiumAmount);
        }

        public void RenewPolicy()
        {
            PremiumAmount += (PremiumAmount*0.1);
            Console.WriteLine("Policy Name : {0} \n Policy Id : {1} \n Updated Premium amount: {2}", PolicyName, PolicyId, PremiumAmount);
        }

        

    }
}
