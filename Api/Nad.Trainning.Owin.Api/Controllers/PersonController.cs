using Nad.Trainning.Server.Business;
using Nad.Trainning.Server.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Nad.Trainning.Owin.Api.Controllers
{
    [RoutePrefix("Person")]
    public class PersonController : ApiController
    {
        private PersonBusiness business;
        public PersonController()
        {
            business = new PersonBusiness();
        }
        public IHttpActionResult Get()
        {
            var result = business.GetAll().FirstOrDefault();
            return Ok(result);
        }
        [Route("getAll")]
        [HttpGet]
        public IList<Person> GetAll()
        {
            return business.GetAll();
        }
        [Route("DeleteById/{Id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int Id) {
            var person = business.GetById(Id);
            business.Delete(person);
            return Ok();
        }
        [Route(), HttpPost]
        public Person Post( [FromBody] Person person)
        {
            var result = business.Save(person);
            return result;     
        }
    }
}