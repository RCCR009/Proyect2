using CoreAPI;
using Entities_POJO;
using Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [ExceptionFilter]
    public class CustomerController : ApiController
    {
        
        // GET api/customer
        public IHttpActionResult Get()
        {

            var mng = new CustomerManager();
            var lstCustomers = mng.RetrieveAll();   
            return Ok(lstCustomers);
        }

        // GET api/customer/5
        public IHttpActionResult Get(string id)
        {
            try
            { 
                var mng = new CustomerManager();
                var customer = new Customer
                {
                    Id = id
                };

                customer = mng.RetrieveById(customer);
                return Ok(customer);
            }
            catch (BussinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
