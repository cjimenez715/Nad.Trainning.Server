using System;
using Nad.Trainning.Server.Business;
using Nad.Trainning.Server.DAO;
using Nad.Trainning.Server.DAO.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Nad.Trainning.Api.Controllers
{
    [RoutePrefix("Cat")]
    public class CatController : ApiController
    {
        private CatBusiness catBusiness;

        public CatController()
        {
            this.catBusiness = new CatBusiness();
        }
        [Route("searchById/{Id}")]
        [HttpGet]
        public Cat GetById(int Id)
        {
            var Cat = catBusiness.GetById(Id);

            return Cat;
        }
        [Route(), HttpPost]
        public Cat Save([FromBody] Cat entitycat)
        {
            var result = catBusiness.save(entitycat);
            return result;
        }
        [Route("searchByName/{name}")]
        [HttpGet]
        public IList<Cat> GetByName(string name)
        {
            return catBusiness.GetByFilter(name);
        }
        [Route("getAll")]
        [HttpGet]
        public IList<Cat> GetAll()
        {
            return catBusiness.GetAll();
        }

        [Route("DeleteById/{Id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int Id)
        {
            var catentity = catBusiness.GetById(Id);
             catBusiness.delete(catentity);
            return Ok();
        }
    }
}
