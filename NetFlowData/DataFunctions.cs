using LinqToDB;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NetFlowPI.Data
{
    class DataFunctions
    {
        public void writeData(NetFlow nf)
        {
            //SPARE-PC3\DEVSQL
            LinqToDB.Data.DataConnection cn = LinqToDB.DataProvider.SqlServer.SqlServerTools.CreateDataConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NetworkData;Data Source=SPARE-PC3\\DEVSQL");

            DataContext db = new DataContext(cn.DataProvider, cn.ConnectionString);
            db.Insert(nf);
        }

    }
}
