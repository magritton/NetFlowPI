using LinqToDB.Mapping;
using System;

namespace NetFlowPI.Data
{
    [Table(Name = "Netflow.NetFlowData")]
    public class NetFlow
    {
        private Guid _NetFlowID;
        [Column(IsPrimaryKey = true, Storage = "_NetFlowID")]
        public Guid NetFlowID
        {
            get
            {
                return this._NetFlowID;
            }
            set
            {
                this._NetFlowID = value;
            }

        }

        private String _Packet;
        [Column(Storage = "_Packet")]
        public String NetFlowPacket
        {
            get
            {
                return this._Packet;
            }
            set
            {
                this._Packet = value;
            }

        }

        private ushort _Version;
        [Column(Storage = "_Version")]
        public ushort Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this._Version = value;
            }

        }

        private ushort _Count;
        [Column(Storage = "_Count")]
        public ushort Count
        {
            get
            {
                return this._Count;
            }
            set
            {
                this._Count = value;
            }

        }

        private ushort _Uptime;
        [Column(Storage = "_Uptime")]
        public ushort UpTime
        {
            get
            {
                return this._Uptime;
            }
            set
            {
                this._Uptime = value;
            }

        }

        private DateTime _Secs;
        [Column(Storage = "_Secs")]
        public DateTime Secs
        {
            get
            {
                return this._Secs;
            }
            set
            {
                this._Secs = value;
            }
        }

        private uint _Sequence;
        [Column(Storage = "_Sequence")]
        public uint Sequence
        {
            get
            {
                return this._Sequence;
            }
            set
            {
                this._Sequence = value;
            }
        }


        private uint _id;
        [Column(Storage = "_id")]
        public uint ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }


        private int _flowsetNum;
        [Column(Storage = "_flowsetNum")]
        public int FlowsetNum
        {
            get
            {
                return this._flowsetNum;
            }
            set
            {
                this._flowsetNum = value;
            }
        }


        private ushort _flowID;
        [Column(Storage = "_flowID")]
        public ushort FlowID
        {
            get
            {
                return this._flowID;
            }
            set
            {
                this._flowID = value;
            }
        }


        private ushort _flowLength;
        [Column(Storage = "_flowLength")]
        public ushort FlowLength
        {
            get
            {
                return this._flowLength;
            }
            set
            {
                this._flowLength = value;
            }
        }


        private ushort _templateID;
        [Column(Storage = "_templateID")]
        public ushort TemplateID
        {
            get
            {
                return this._templateID;
            }
            set
            {
                this._templateID = value;
            }
        }


        private ushort _templateCount;
        [Column(Storage = "_templateCount")]
        public ushort TemplateCount
        {
            get
            {
                return this._templateCount;
            }
            set
            {
                this._templateCount = value;
            }
        }


        private UInt16 _LAST_SWITCHED;
        [Column(Storage = "_LAST_SWITCHED")]
        public UInt16 LAST_SWITCHED
        {
            get
            {
                return this._LAST_SWITCHED;
            }
            set
            {
                this._LAST_SWITCHED = value;
            }
        }


        private UInt16 _FIRST_SWITCHED;
        [Column(Storage = "_FIRST_SWITCHED")]
        public UInt16 FIRST_SWITCHED
        {
            get
            {
                return this._FIRST_SWITCHED;
            }
            set
            {
                this._FIRST_SWITCHED = value;
            }
        }


        private UInt16 _IN_BYTES;
        [Column(Storage = "_IN_BYTES")]
        public UInt16 IN_BYTES
        {
            get
            {
                return this._IN_BYTES;
            }
            set
            {
                this._IN_BYTES = value;
            }
        }


        private UInt16 _IN_PKTS;
        [Column(Storage = "_IN_PKTS")]
        public UInt16 IN_PKTS
        {
            get
            {
                return this._IN_PKTS;
            }
            set
            {
                this._IN_PKTS = value;
            }
        }

        private UInt16 _IP_PROTOCOL_VERSION;
        [Column(Storage = "_IP_PROTOCOL_VERSION")]
        public UInt16 IP_PROTOCOL_VERSION
        {
            get
            {
                return this._IP_PROTOCOL_VERSION;
            }
            set
            {
                this._IP_PROTOCOL_VERSION = value;
            }
        }


        private UInt16 _INPUT_SNMP;
        [Column(Storage = "_INPUT_SNMP")]
        public UInt16 INPUT_SNMP
        {
            get
            {
                return this._INPUT_SNMP;
            }
            set
            {
                this._INPUT_SNMP = value;
            }
        }


        private UInt16 _OUTPUT_SNMP;
        [Column(Storage = "_OUTPUT_SNMP")]
        public UInt16 OUTPUT_SNMP
        {
            get
            {
                return this._OUTPUT_SNMP;
            }
            set
            {
                this._OUTPUT_SNMP = value;
            }
        }


        private UInt16 _DIRECTION;
        [Column(Storage = "_DIRECTION")]
        public UInt16 DIRECTION
        {
            get
            {
                return this._DIRECTION;
            }
            set
            {
                this._DIRECTION = value;
            }
        }


        private UInt16 _FLOWS;
        [Column(Storage = "_FLOWS")]
        public UInt16 FLOWS
        {
            get
            {
                return this._FLOWS;
            }
            set
            {
                this._FLOWS = value;
            }
        }


        private String _IPV4_SRC_ADDR;
        [Column(Storage = "_IPV4_SRC_ADDR")]
        public String IPV4_SRC_ADDR
        {
            get
            {
                return this._IPV4_SRC_ADDR;
            }
            set
            {
                this._IPV4_SRC_ADDR = value;
            }
        }


        private String _IPV4_DST_ADDR;
        [Column(Storage = "_IPV4_DST_ADDR")]
        public String IPV4_DST_ADDR
        {
            get
            {
                return this._IPV4_DST_ADDR;
            }
            set
            {
                this._IPV4_DST_ADDR = value;
            }
        }


        private String _IPV4_NEXT_HOP;
        [Column(Storage = "_IPV4_NEXT_HOPIPV4_NEXT_HOP")]
        public String IPV4_NEXT_HOP
        {
            get
            {
                return this.IPV4_NEXT_HOP;
            }
            set
            {
                this._IPV4_NEXT_HOP = value;
            }
        }


        private String _IPV6_DST_ADDR;
        [Column(Storage = "_IPV6_DST_ADDR")]
        public String IPV6_DST_ADDR
        {
            get
            {
                return this._IPV6_DST_ADDR;
            }
            set
            {
                this._IPV6_DST_ADDR = value;
            }
        }


        private String _IPV6_SRC_ADDR;
        [Column(Storage = "_IPV6_SRC_ADDR")]
        public String IPV6_SRC_ADDR
        {
            get
            {
                return this._IPV6_SRC_ADDR;
            }
            set
            {
                this._IPV6_SRC_ADDR = value;
            }
        }


        private String _IPV6_NEXT_HOP;
        [Column(Storage = "_IPV6_NEXT_HOP")]
        public String IPV6_NEXT_HOP
        {
            get
            {
                return this._IPV6_NEXT_HOP;
            }
            set
            {
                this._IPV6_NEXT_HOP = value;
            }
        }

        private UInt16 _L4_SRC_PORT;
        [Column(Storage = "_L4_SRC_PORT")]
        public UInt16 L4_SRC_PORT
        {
            get
            {
                return this._L4_SRC_PORT;
            }
            set
            {
                this._L4_SRC_PORT = value;
            }
        }


        private UInt16 _L4_DST_PORT;
        [Column(Storage = "_L4_DST_PORT")]
        public UInt16 L4_DST_PORT
        {
            get
            {
                return this._L4_DST_PORT;
            }
            set
            {
                this._L4_DST_PORT = value;
            }
        }


        private UInt16 _TOS;
        [Column(Storage = "_TOS")]
        public UInt16 TOS
        {
            get
            {
                return this._TOS;
            }
            set
            {
                this._TOS = value;
            }
        }


        private UInt16 _TCP_FLAGS;
        [Column(Storage = "_TCP_FLAGS")]
        public UInt16 TCP_FLAGS
        {
            get
            {
                return this._TCP_FLAGS;
            }
            set
            {
                this._TCP_FLAGS = value;
            }
        }


        private UInt16 _PROTOCOL;
        [Column(Storage = "_PROTOCOL")]
        public UInt16 PROTOCOL
        {
            get
            {
                return this._PROTOCOL;
            }
            set
            {
                this._PROTOCOL = value;
            }
        }


        private UInt16 _EightyOne;
        [Column(Storage = "_EightyOne")]
        public UInt16 EightyOne
        {
            get
            {
                return this._EightyOne;
            }
            set
            {
                this._EightyOne = value;
            }
        }


        private UInt16 _DST_MAC;
        [Column(Storage = "_DST_MAC")]
        public UInt16 DST_MAC
        {
            get
            {
                return this._DST_MAC;
            }
            set
            {
                this._DST_MAC = value;
            }
        }


        private UInt16 _DST_VLAN;
        [Column(Storage = "_DST_VLAN")]
        public UInt16 DST_VLAN
        {
            get
            {
                return this._DST_VLAN;
            }
            set
            {
                this._DST_VLAN = value;
            }
        }


        private UInt16 _TwoOne;
        [Column(Storage = "_TwoOne")]
        public UInt16 TwoOne
        {
            get
            {
                return this._TwoOne;
            }
            set
            {
                this._TwoOne = value;
            }
        }
    }
}
