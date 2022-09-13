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
        List<Ese> eseList = new List<Ese>();

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }

        public int liseEse(int ese) { return ese; }

        public int punktide_arv()
        {
            int damage=0;
            foreach (Ese ese in eseList)
            {
                damage += ese.PunktideArv();
            }
            return damage;
        }


        public string Info()
        {
            throw new NotImplementedException();
        }

        public int PunktideArv()
        {
            throw new NotImplementedException();
        }
    }
}
