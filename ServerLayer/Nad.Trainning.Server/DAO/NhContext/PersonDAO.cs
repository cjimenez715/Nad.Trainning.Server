using Nad.Trainning.Server.DAO.Contract;
using Nad.Trainning.Server.DAO.Entities;
using Sda.Data.NHibernateAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nad.Trainning.Server.DAO.NhContext
{
    public class PersonDAO : DataAccess<Person>, IPersonDAO
    {
    }
}
