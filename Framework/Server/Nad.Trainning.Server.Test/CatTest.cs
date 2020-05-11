using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nad.Trainning.Server.Business;
using Nad.Trainning.Server.DAO.Entities;

namespace Nad.Trainning.Server.Test
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void GetAllTest()
        {
            var business = new CatBusiness();
            var result = business.GetAll();
        }

        [TestMethod]
        public void SaveTest()
        {
            var business = new CatBusiness();
            var result = business.save(new Cat
            {
                Code = "0001",
                Name = "Google"
            }
            );
            
        }
        [TestMethod]
        public void getAll()
        {
            var business = new CatBusiness();
            var result = business.GetAll();
        }
        [TestMethod]
        public void getByName()
        {
            var business = new CatBusiness();
            var catResult = business.GetByFilter("google");
        }

        [TestMethod]
        public void getById()
        {
            var business = new CatBusiness();
            var catResult = business.GetById(2);
        }
    }
}
