using DataAcess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class CustomerManagement
    {

        public void Create()
        {

            var customer = new Customer();
            customer.Id = "0101110111";
            customer.Name = "Chapulin";
            customer.LastName = "Colorado";
            customer.Age = 66;

            try {
                var crudCustomer = new CustomerCrudFactory();
                crudCustomer.Create(customer);
                Console.WriteLine("Customer was created");

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }

    }
}
