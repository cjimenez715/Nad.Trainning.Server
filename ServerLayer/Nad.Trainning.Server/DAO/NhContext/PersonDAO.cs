using Nad.Trainning.Server.DAO.Contract;
using Nad.Trainning.Server.DAO.Entities;
using Sda.Data.NHibernateAccess;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace Nad.Trainning.Server.DAO.NhContext
{
    public class PersonDAO : DataAccess<Person>, IPersonDAO
    {
        IList<Person> IPersonDAO.GetByFilter(string filter)
        {
            ICriteria criteria = GetDefaultSession().CreateCriteria(typeof(Person));
            criteria.Add(Expression.Or(Expression.Like("Code", filter + Sda.Core.Data.Constants.WILDCARD),
                                       Expression.Like("Name", filter + Sda.Core.Data.Constants.WILDCARD)));
            return criteria.List<Person>();
        }
    }
}
