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
        public void writeData()
        {
            //SPARE-PC3\DEVSQL
            DataContext db = new DataContext("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NetworkData;Data Source=SPARE-PC3\\DEVSQL");
            //Data Source=localhost;Initial Catalog=dbname; Integrated Security=True" providerName="System.Data.SqlClient
            //ITable<NetFlow> table = db.GetTable<NetFlow>();
            NetFlow nf = new NetFlow();
            nf.Count = 0;
            nf.DIRECTION = 1;
            nf.DST_MAC = 2;
            nf.DST_VLAN = 3;
            nf.EightyOne = 4;
            nf.FIRST_SWITCHED = 5;
            nf.FlowID = 6;
            nf.FlowLength = 7;
            nf.FLOWS = 8;
            nf.FlowsetNum = 9;
            nf.ID = 10;
            nf.INPUT_SNMP = 11;
            nf.IN_BYTES = 12;
            nf.IN_PKTS = 13;
            nf.IPV4_DST_ADDR = "123.1.1.4";
            nf.IPV4_SRC_ADDR = "456.1.1.1";
            nf.IP_PROTOCOL_VERSION = 14;
            nf.L4_DST_PORT = 15;
            nf.L4_SRC_PORT = 16;
            nf.LAST_SWITCHED = 17;
            nf.NetFlowID = Guid.NewGuid();
            nf.NetFlowPacket = "18";
            nf.OUTPUT_SNMP = 19;
            nf.PROTOCOL = 20;
            nf.Secs = DateTime.Now;
            nf.Sequence = 21;
            nf.TCP_FLAGS = 22;
            nf.TemplateCount = 23;
            nf.TemplateID = 24;
            nf.TOS = 25;
            nf.TwoOne = 26;
            nf.UpTime = 265;
            nf.Version = 27;
            db.Insert(nf);
        }

    }
}
