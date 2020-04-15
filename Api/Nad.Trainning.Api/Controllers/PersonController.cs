using Nad.Trainning.Server.Business;
using Nad.Trainning.Server.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Nad.Trainning.Api.Controllers
{
    public class PersonController : ApiController
    {

        private PersonBusiness business;

        public PersonController()
        {
            business = new PersonBusiness();
        }
        public List<Person> Get()
        {
            return business.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
