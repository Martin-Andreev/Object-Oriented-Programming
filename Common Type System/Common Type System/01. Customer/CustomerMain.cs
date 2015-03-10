namespace Customer
{
    using System;
    using System.Collections.Generic;

    public class CustomerMain
    {
        static void Main()
        {
            Payment water = new Payment("Water", 87.90m);
            Payment phone = new Payment("Phone", 40.50m);
            Payment car = new Payment("Car", 5000m);
            Payment sport = new Payment("Sport", 50m);
            List<Payment> payments = new List<Payment>(){ water, phone };
            List<Payment> pleasurePayments = new List<Payment>() { car, sport };

            Customer boicho = new Customer("Boicho", "Petrov", "Ognianov", 7501079340, "Sofia 50-60", "+359886 55 66 77", "boicho@abv.bg", payments, CustomerType.Regular);
            Customer tosho = new Customer("Todor", "Stoianov", "Petrov", 7106059642, "Plovdiv 44-66", "+359887 12 11 12", "tosheto@abv.bg", pleasurePayments, CustomerType.Golden);
            
            Customer bobcho = (Customer)boicho.Clone();

            Console.WriteLine(boicho.ToString());
            Console.WriteLine("Boicho compare to Tosho: " + boicho.CompareTo(tosho));
            Console.WriteLine("Bobcho equals boicho: " + bobcho.Equals(boicho));
            Console.WriteLine("Boicho != Tosho: {0}", boicho != tosho);
            Console.WriteLine("Tosho == Boicho: {0}", tosho == boicho);
            Console.WriteLine("Bobcho HashCode: " + bobcho.GetHashCode());
        }
    }
}
