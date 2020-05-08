using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nad.Trainning.Server.Business;
using Nad.Trainning.Server.DAO.Entities;

namespace Nad.Trainning.Server.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void GetAllTest()
        {
            var business = new PersonBusiness();
            var result = business.GetAll();
        }

        [TestMethod]
        public void SaveTest()
        {
            var business = new PersonBusiness();
            var person = new Person();
            person.Name = "Test Save";
            person.LastName = "From GIT";
            person.Age = 50;
            var result = business.Save(person);
        }


        [TestMethod]
        public void GetAllTes2t()
        {
            var business = new PersonBusiness();
            var result = business.GetAll();
        }
    }
}
