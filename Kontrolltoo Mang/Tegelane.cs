using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Tegelane : IUksus , IComparable<Tegelane>
    {
        private string nimi;
        
        List<Ese> eseList;

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
            //eseList = new List<Ese<();
        }

        public int CompareTo(Tegelane? muu)
        {
            if (muu==null)
            {
                return 1;
            }
            return this.eseList.Count - muu.EsedKogus();
        }


        public int liseEse(int ese) { return ese; }

        public int PunktideArv()
        {
            int damage = 0;
            foreach (Ese ese in eseList)
            {
                damage += ese.PunktideArv();
            }
            return damage;
        }


        public string Info()
        {
            string tegelaseInfo;
            tegelaseInfo = nimi+ ", " + eseList.Count() + ", " + PunktideArv();
            return tegelaseInfo;
        }

        public void valjastaEsemed()
        {
            Console.WriteLine("Esemed >>> ");
            foreach (Ese item in eseList)
            {
                Console.WriteLine(item.Info());
            }
            Console.WriteLine();
        }

        private int EsedKogus() { return this.eseList.Count(); }

        
    }
}
