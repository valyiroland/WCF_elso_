using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF_elso_server.Models
{
    [DataContract]
    public class Cd
    {
        [DataMember]
        public int cdAz { get; set; }

        [DataMember]
        public string cdCim { get; set; }

        [DataMember]
        public string kiado { get; set; }
    }
}
