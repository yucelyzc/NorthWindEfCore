using System;


using NorthWindEfCore.Models;

namespace NorthWindEfCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();
            //Select *From Products Where UnıtsınStock
            var result =context.Product.Where(p => p.UnitsInStock).ToList;

            var result1 = context.Orders.Where(o => o.OrderDate == DateTime.Parse("1997-05-17"));

            var result2=context.Customers.Where(c=>c.City.StartsWith("A")||c.City.StartsWith("B"));
            var result3=context.Employee.Where(e=>e.ReportsTo==null);
            var result4=context.Product.Where(p=>p.SupplierId)

        }
    }
}