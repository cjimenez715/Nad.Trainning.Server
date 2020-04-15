using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nad.Trainning.Server.Business;

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
    }
}
