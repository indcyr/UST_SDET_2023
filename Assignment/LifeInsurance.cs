using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment 
{
    internal class LifeInsurance : InsurancePolicyAbs
    {
        public LifeInsurance(string? policyName, int policyId, double premiumAmount,int age) 
        {
            Age = age;
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
           
        }

        public int Age { get; set; }

         
public override double CalculatePremium()
        {
            if (Age <= 15)
                PremiumAmount += PremiumAmount * 0.15;
            else if (Age > 15 && Age <= 40)
                PremiumAmount += PremiumAmount * 0.25;
            else if (Age > 40 && Age <= 65)
                PremiumAmount += PremiumAmount * 0.35;
            if (Age > 65)
                PremiumAmount += PremiumAmount * 0.4;
            return PremiumAmount;
            
        }
    }
   


}
