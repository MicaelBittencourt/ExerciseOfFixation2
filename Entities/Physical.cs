using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    class Physical : People
    {
        public double HealthSpending { get; set; }

        public Physical()
        {
        }

        public Physical(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            double taxAI=0;
            double taxHS=0;
            if(AnnualIncome < 20000)
            {
                taxAI = AnnualIncome * 0.15;
            }
            else
            {
                taxAI = AnnualIncome * 0.20;
            }

            if(HealthSpending < 0)
            {
                taxHS = HealthSpending * 0.50;
            }
            return taxAI-taxHS;
        }
    }
}
