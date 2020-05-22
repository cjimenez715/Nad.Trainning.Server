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
        [Route("getById/{Id}")]
        [HttpGet]
        public Person GetById(int id)
        {
            return business.GetById(id);
        }
        [Route("getAll")]
        [HttpGet]
        public IList<Person> GetAll()
        {
            return business.GetAll();
        }

        [Route("getByFilterExceptId/{filter}/{id}")]
        [HttpGet]
        public IList<Person> GetByFilterExceptId(string filter, int id)
        {
            return business.GetByFilterExceptId(filter, id);
        }
        [Route("deleteById/{Id}")]
        [HttpDelete]
        public void Delete(int Id) {
            var person = business.GetById(Id);
            business.Delete(person);
        }
        [Route(), HttpPost, HttpPut]
        public Person Post( [FromBody] Person person)
        {
            var result = business.Save(person);
            return result;     
        }
    }
}