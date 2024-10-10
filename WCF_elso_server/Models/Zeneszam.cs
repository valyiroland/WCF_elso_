using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_elso_server.Models
{
    [DataContract]
    public class Zeneszam
    {
        
        [DataMember]
        public int zeneszamAz { get; set; }

        [DataMember]
        public string zeneszamCim { get; set; }

        [DataMember]
        public int zeneszamHossz { get; set; }

        public override string ToString()
        {
            return $"{zeneszamAz};{zeneszamCim};{zeneszamHossz}";
        }

    }
}

