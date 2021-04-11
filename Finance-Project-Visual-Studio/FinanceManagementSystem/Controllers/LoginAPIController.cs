using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FinanceManagementSystem.Models;
using System;

namespace FinanceManagementSystem.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/LoginAPI")]
    public class LoginAPIController : ApiController
    {
        FinanceManagementEntities db = new FinanceManagementEntities();
        [Route("api/LoginAPI/Login/{name}/{pwd}")]
        [HttpGet]
        public bool Get(string userName, string userPwd)
        {
            bool result;
            try
            {
                var data = db.Customers.Where(x => x.CustUsername == userName && x.CustPassword == userPwd);
                if (data.Count() == 0)
                    result = true;
                else
                    result = false;
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
    }
}
