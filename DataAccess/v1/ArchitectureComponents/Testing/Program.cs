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
            var mng = new CustomerManagement();
            var customer = new Customer();

            try
            {
                Console.WriteLine("Customers CRUD options");
                Console.WriteLine("1.CREATE");
                Console.WriteLine("2.RETRIEVE ALL");
                Console.WriteLine("3.RETRIEVE BY ID");
                Console.WriteLine("4.UPDATE");
                Console.WriteLine("5.DELETE");

                Console.WriteLine("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****     CREATE    *******");
                        Console.WriteLine("***************************");
                        Console.WriteLine("Type the id, name, last_name and age separated by comma");
                        var info = Console.ReadLine();
                        var infoArray = info.Split(',');

                        customer = new Customer(infoArray);
                        mng.Create(customer);

                        Console.WriteLine("Customer was created");

                        break;

                    case "2":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****  RETRIEVE ALL   *****");
                        Console.WriteLine("***************************");

                        var lstCustomers = mng.RetrieveAll();
                        var count = 0;

                        foreach (var c in lstCustomers)
                        {
                            count++;
                            Console.WriteLine( count + " ==> " + c.GetEntityInformation());
                        }

                        break;

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
