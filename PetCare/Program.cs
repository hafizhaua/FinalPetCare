using System;
using System.Collections.Generic;
using PetCare.Entities;
using System.Linq;

namespace PetCare
{
    class Program
    {
		static void Main(string[] args)
		{
            using (var context = new AppPetCareContext())
            {
                var customer1 = new Customer
                {
                    Username = "pboasyik",
                    Password = "asyikbanget"
                };

                var customer2 = new Customer
                {
                    Username = "CatRescuer",
                    Password = "ilovecat"
                };

                context.Customers.Add(customer1);
                context.Customers.Add(customer2);
                context.SaveChanges();
            }

            LoginController.Index();
        }
    }
}
