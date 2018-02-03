using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var customer = new Customer();
                customer.Id = "0101110114";
                customer.Name = "Chapulin";
                customer.LastName = "Colorado";
                customer.Age = 66;

                var mng = new CustomerManagement();
                mng.Create(customer);

                Console.WriteLine("Customer was created");

                var lstCustomers = mng.RetrieveAll();

                foreach(var c in lstCustomers)
                {
                    Console.WriteLine("Name==> " + c.Name);
                }

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
           
        }
    }
}
