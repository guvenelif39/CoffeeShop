using CoffeeShop.Abstract;
using CoffeeShop.Adapters;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1997, 10, 28),
                FirstName = "Elif",
                LastName = "Güven",
                NationalityId = "11243974652",
                
            });
            Console.ReadLine();
        }
    }
}
