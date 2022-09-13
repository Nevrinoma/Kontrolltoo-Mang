using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Tegelane : Uksus
    {
        private string nimi;
        int damage = 0;
        List<Ese> eseList = new List<Ese>();

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }

        public int liseEse(int ese) { return ese; }

        public int punktide_arv()
        {
            
            foreach (Ese ese in eseList)
            {
                damage += ese.PunktideArv();
            }
            return damage;
        }


        public string Info()
        {
            Console.WriteLine($"Nimi >>> {nimi}\nPunktide Arv >>>{damage}");
            return ($"Nimi >>> {nimi}\nPunktide Arv >>>{damage}");
        }

        public string valjastaEsemed()
        {
            return valjastaEsemed();
        }


        public int PunktideArv()
        {
            throw new NotImplementedException();
        }
    }
}
