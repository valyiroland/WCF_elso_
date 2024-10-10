using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WCF_elso_server.Models;
using System.Security.Cryptography.X509Certificates;

namespace WCF_elso_server.Controllers
{
    public class EloadoController
    {
        public List<Eloado> EloadokLista()
        {


            List<Eloado> eloadok = new List<Eloado>();
            string[] sorok = File.ReadAllLines("C:\\Users\\vroli\\OneDrive\\Asztali gép\\WCF_elso\\WCF_elso_server\\EloadoAdatok.txt");
           for (int i = 1; i < sorok.Length; i++)
            {
                string[] bontas = sorok[i].Split(';');
                eloadok.Add(new Eloado
                {
                    eloadoAz = int.Parse(bontas[0]),
                    eloadoName = bontas[1]
                });
                
            }
               return eloadok;

        }
        int GenerateID()
        {
           return EloadokLista().Select(eloado => eloado.eloadoAz).ToList().Max()
                +1;
        }

        public string InsertEloado(Eloado eloado)
        {
            eloado.eloadoAz = GenerateID();
            StreamWriter kimenet = new StreamWriter("C:\\Users\\vroli\\OneDrive\\Asztali gép\\WCF_elso\\WCF_elso_server\\EloadoAdatok.txt", true);
            
            kimenet.WriteLine(eloado.ToString());

            kimenet.Close();

            return "Sikeresen mentettük az előadót.";
        }
        //
        public string UpdateEloado(Eloado eloado)
        {
            //1.lépés beolvasok az állománybol egy listába
           

            List<Eloado>aktuális= EloadokLista();

            //2.lépés a listában megkeresem a megfelelő azonosítot ha megvan módosítom az adatokat
            int index = 0;
            while (index<aktuális.Count && aktuális[index].eloadoAz != eloado.eloadoAz)
            {
                index++;
            }
            if (index<aktuális.Count)
            {
                aktuális[index].eloadoName=eloado.eloadoName;
                //3. lépés A módosított listával újra generálom az állományt.
               StreamWriter ujallomany = new StreamWriter("C:\\Users\\vroli\\OneDrive\\Asztali gép\\WCF_elso\\WCF_elso_server\\EloadoAdatok.txt");
                ujallomany.WriteLine("eloadoAzon;eloadoName");
                foreach (Eloado item in aktuális)
                {
                   ujallomany.WriteLine(item.ToString());
                }
               ujallomany.Close();
                return "Amódosítás sikeres";

            }
            else
            {
                return "Nincs ilyen azonosítóju előadó";
            }

            
            



           
//Ha nem találom akkor nem változtatok csak üzenem hogy nincs ilyen.

        }

        public string DeletEloado(int id) {
            List<Eloado> aktuális1 = EloadokLista();
            int index = 0;
            while (index < aktuális1.Count && aktuális1[index].eloadoAz != id)
            {
                index++;
            }
            if (index < aktuális1.Count)
            {
                aktuális1.RemoveAt(index);
                //3. lépés A módosított listával újra generálom az állományt.
                StreamWriter ujallomany = new StreamWriter("C:\\Users\\vroli\\OneDrive\\Asztali gép\\WCF_elso\\WCF_elso_server\\EloadoAdatok.txt");
                ujallomany.WriteLine("eloadoAzon;eloadoName");
                foreach (Eloado item in aktuális1)
                {
                    ujallomany.WriteLine(item.ToString());
                }
                ujallomany.Close();
                return "A törlés sikeres";

            }
            else
            {
                return "Nincs ilyen azonosítóju előadó";
            }

            return "";
        }





    }
}
