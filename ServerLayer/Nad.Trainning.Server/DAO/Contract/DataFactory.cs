using Sda.Core.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nad.Trainning.Server.DAO.Contract
{
    public class DataFactory : DataContextFactory
    {
        static DataFactory instance = null;
        public static  DataFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataFactory();
                return instance;
            }
        }

        public DataFactory()
        {
            InitializeFactory("Sda-aasi-DataContext");
        }

        public IPersonDAO GetPersonDAO()
        {
            return this.GetInstance<IPersonDAO>("PersonDAO");
     
   }
        public ICatDAO GetCatDAO()
        {
            return this.GetInstance<ICatDAO>("CatDAO");
        }
    }
}
