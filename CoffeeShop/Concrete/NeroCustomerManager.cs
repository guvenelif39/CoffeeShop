using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Concrete
{
    class NeroCustomerManager : BaseCustomerManager
    {
        //Nero firması Mernis doğrulaması kullanmak isterse:

        //private ICustomerCheckService _customerCheckService;
        //public NeroCustomerManager(ICustomerCheckService customerCheckService)
        //{
        //    _customerCheckService = customerCheckService;
        //}

        //public override void Save(Customer customer)
        //{
        //    if (_customerCheckService.CheckIfRealPerson(customer))
        //    {
        //        base.Save(customer);
        //    }
        //    else
        //    {
        //        throw new Exception("Not a valid person.");
        //    }
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }

    }
}
