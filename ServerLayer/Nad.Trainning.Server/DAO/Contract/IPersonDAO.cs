﻿using Nad.Trainning.Server.DAO.Entities;
using Sda.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nad.Trainning.Server.DAO.Contract
{
    public interface IPersonDAO : IDataAccess<Person>
    {
        IList<Person> GetByFilter(string filter);
    }
}
