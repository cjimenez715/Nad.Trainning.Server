using Nad.Trainning.Server.Business;
using Nad.Trainning.Server.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Nad.Trainning.Owin.Api.Controllers
{
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


        public Person Post(Person person)
        {
            var result = business.Save(person);
            return result;     
        }
    }
}