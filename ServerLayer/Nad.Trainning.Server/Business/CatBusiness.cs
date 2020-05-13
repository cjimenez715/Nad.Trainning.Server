using Nad.Trainning.Server.DAO.Contract;
using Nad.Trainning.Server.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nad.Trainning.Server.Business
{
    public class CatBusiness
    {
        private ICatDAO dataAccess;
    
    public CatBusiness()
    {
        dataAccess = DataFactory.Instance.GetCatDAO();
    }
    public Cat save(Cat cat)
    {
            return dataAccess.Save(cat);
    }

        public void delete(Cat cat)
        {
            dataAccess.Delete(cat);
        }

        public Cat GetById(int id)
        {
            return dataAccess.Select(id);
        }
        public IList<Cat> GetByFilter(string filter)
        {
            return dataAccess.GetByFilter(filter);
        }
        public List<Cat> GetAll()
        {
            return dataAccess.GetAll().ToList();
        }
    }
}
