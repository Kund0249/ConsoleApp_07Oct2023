using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_07Oct2023.OOPS.BanckAccount
{
   abstract class LoanAccount
    {
        public string AccountNumber;
        public string AccountHolder;
        public int Tenure;
        public float EMI;
        public float PrincpleAmount;
        public float ROI;

        public float GetIntrest()
        {
            return (PrincpleAmount * Tenure * ROI) / 100;
        }

        public float TotalAmount()
        {
            float TotalIntrest = (PrincpleAmount * Tenure * ROI) / 100;
            return PrincpleAmount + TotalIntrest;
        }
    }
}
