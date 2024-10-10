using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WCF_elso_server.Models;

namespace WCF_elso_server.Controllers
{
    public class ZeneszamController
    {
        public List<Zeneszam> ZeneszamokLista()
        {


            List<Zeneszam> zeneszamok = new List<Zeneszam>();
            string[] sorok = File.ReadAllLines("C:\\Users\\vroli\\OneDrive\\Asztali gép\\WCF_elso\\WCF_elso_server\\ZeneszamAdatok.txt");
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] bontas = sorok[i].Split(';');
                zeneszamok.Add(new Zeneszam
                {
                    zeneszamAz = int.Parse(bontas[0]),
                    zeneszamCim = bontas[1],
                    zeneszamHossz = int.Parse(bontas[2]),
                });

            }
            return zeneszamok;

        }
        int GenerateID()
        {
            return ZeneszamokLista().Select(zeneszam => zeneszam.zeneszamAz).ToList().Max()
                 + 1;
        }

        public string InsertZeneszam(Zeneszam ujZeneszam)
        {
            ujZeneszam.zeneszamAz = GenerateID();
            StreamWriter kimenet = new StreamWriter("C:\\Users\\vroli\\OneDrive\\Asztali gép\\WCF_elso\\WCF_elso_server\\ZeneszamAdatok.txt",true);

            kimenet.WriteLine(ujZeneszam.ToString());

            kimenet.Close();

            return "Sikeresen mentettük az Zeneszámot.";
        }
        //
        public string UpdateZeneszam(Zeneszam zeneszam)
        {
            //1.lépés beolvasok az állománybol egy listába


            List<Zeneszam> aktuális = ZeneszamokLista();

            //2.lépés a listában megkeresem a megfelelő azonosítot ha megvan módosítom az adatokat
            int index = 0;
            while (index < aktuális.Count && aktuális[index].zeneszamAz != zeneszam.zeneszamAz)
            {
                index++;
            }
            if (index < aktuális.Count)
            {
                aktuális[index].zeneszamCim = zeneszam.zeneszamCim;
                //3. lépés A módosított listával újra generálom az állományt.
                StreamWriter ujallomany = new StreamWriter("C:\\Users\\vroli\\OneDrive\\Asztali gép\\WCF_elso\\WCF_elso_server\\ZeneszamAdatok.txt");
                ujallomany.WriteLine("zeneszamAzon;zeneszamCim;zeneszamHossz");
                foreach (Zeneszam item in aktuális)
                {
                    ujallomany.WriteLine(item.ToString());
                }
                ujallomany.Close();
                return "A módosítás sikeres";

            }
            else
            {
                return "Nincs ilyen azonosítóju Zeneszam";
            }







            //Ha nem találom akkor nem változtatok csak üzenem hogy nincs ilyen.

        }

        public string DeletZeneszam(int id)
        {
            List<Zeneszam> aktuális1 = ZeneszamokLista();
            int index = 0;
            while (index < aktuális1.Count && aktuális1[index].zeneszamAz != id)
            {
                index++;
            }
            if (index < aktuális1.Count)
            {
                aktuális1.RemoveAt(index);
                //3. lépés A módosított listával újra generálom az állományt.
                StreamWriter ujallomany = new StreamWriter("C:\\Users\\vroli\\OneDrive\\Asztali gép\\WCF_elso\\WCF_elso_server\\ZeneszamAdatok.txt");
                ujallomany.WriteLine("zeneszamAzon;zeneszamCim;zeneszamHossz");
                foreach (Zeneszam item in aktuális1)
                {
                    ujallomany.WriteLine(item.ToString());
                }
                ujallomany.Close();
                return "A törlés sikeres";

            }
            else
            {
                return "Nincs ilyen azonosítóju Zeneszam";
            }

            return "";
        }



    }
}