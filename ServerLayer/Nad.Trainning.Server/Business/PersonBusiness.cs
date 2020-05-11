using Nad.Trainning.Server.DAO.Contract;
using Nad.Trainning.Server.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nad.Trainning.Server.Business
{
    public class PersonBusiness
    {
        private IPersonDAO dataAccess;

        public PersonBusiness()
        {
            dataAccess = DataFactory.Instance.GetPersonDAO();
        }

        public Person Save(Person person)
        {
            return dataAccess.Save(person);
        }

        public void Delete(Person person)
        {
            dataAccess.Delete(person);
        }

        public List<Person> GetAll()
        {
            return dataAccess.GetAll().ToList();
        }

        public Person GetById(int id)
        {
            return dataAccess.Select(id);
        }
        public IList<Person> GetByFilter(string filter)
        {
            return dataAccess.GetByFilter(filter);
        }
    }
}
