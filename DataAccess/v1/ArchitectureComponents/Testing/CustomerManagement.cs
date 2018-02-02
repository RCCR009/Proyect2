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
        private CustomerCrudFactory crudFactory;

        public CustomerManagement()
        {
            crudFactory = new CustomerCrudFactory();
        }

        public void Create(Customer customer)
        {
            var crudCustomer = new CustomerCrudFactory();
            crudCustomer.Create(customer);

        }

    }
}
