using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_elso_server.Models;
using WCF_elso_server.Controllers;

namespace WCF_elso_server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       

        public List<Eloado> GetEloado()
        {
            List<Eloado> list = new EloadoController().EloadokLista();

            return list;
        }

        public string GetEloadoName()
        {
            Eloado eloado = new Eloado()
            {
                eloadoAz = 1,
                eloadoName = "Queen"
            };
            return eloado.eloadoName;
        }

        public Zeneszam GetZeneszam()
        {
            Zeneszam zeneszam = new Zeneszam()
            {
                zeneszamAz= 1,
                zeneszamCim= "cim",
                zeneszamHossz= 315
                
            };
            return zeneszam;
        }
        public Cd GetCd()
        {
           
          Cd cd = new Cd()
           {
             cdAz = 1,
             cdCim = "Kind of magic",
             kiado = "Capitol"

          }; return cd;
            
        }

        public string UjEloado(Eloado eloado)
        {
           
            return new EloadoController().InsertEloado(eloado);
        }

        public string ModositEloado(Eloado eloado)
        {
            return new EloadoController().UpdateEloado(eloado);
        }

        public string TorolEloado(int id)
        {
            return "";
        }

        public string UjZeneszam(Zeneszam ujZeneszam)
        {
            return new ZeneszamController().InsertZeneszam(ujZeneszam);
        }

        public string ModositZeneszam(Zeneszam zeneszam)
        {
            return new ZeneszamController().UpdateZeneszam(zeneszam);
        }

        public string TorolZeneszam(int id)
        {
            return "";
        }
    }
}
