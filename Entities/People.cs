﻿namespace ConsoleApp1.Entities
{
    abstract class People
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public People()
        {
        }

        public People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
