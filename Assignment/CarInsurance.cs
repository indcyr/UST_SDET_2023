using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class CarInsurance : InsurancePolicyAbs
    {
        public CarInsurance(string? policyName, int policyId, double premiumAmount, string? fuelType)
        {
            FuelType = fuelType;
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
        }

        public string? FuelType { get; set; }

        public override double CalculatePremium()
        {
            if (FuelType == "Petrol")
                PremiumAmount += PremiumAmount * 0.35;
            else if (FuelType == "Diesel")
                PremiumAmount += PremiumAmount * 0.40;
            else if (FuelType == "CNG")
                PremiumAmount += PremiumAmount * 0.3;
            else
                PremiumAmount += PremiumAmount * 0.38;
            return PremiumAmount;
        }
    }
}
