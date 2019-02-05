using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1.Entities
{
    class Legal : People
    {
        public int NumberEmployed { get; set; }

        public Legal()
        {
        }

        public Legal(string name, double annualIncome, int numberEmployed) : base(name, annualIncome)
        {
            NumberEmployed = numberEmployed;
        }

        public override double Tax()
        {
            if(NumberEmployed > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
        public override string ToString()
        {
            return  Name + " $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
