using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FinanceManagementSystem.Models;
namespace FinanceManagementSystem.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/RegistrationAPI")]
    public class RegistrationAPIController : ApiController
    {
        FinanceManagementEntities fm = new FinanceManagementEntities();
        [Route("api/RegistrationAPI/RegisterData")]
        [HttpPost]
        public bool Post([FromBody]Customer cust)
        {
            try 
            {
                fm.Customers.Add(cust);
                var res = fm.SaveChanges();
                if (res > 0)
                    return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }
    }
}
