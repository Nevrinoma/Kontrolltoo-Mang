using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Mang
    {
        private Tegelane[] tegelased;

        public Mang(Tegelane[] tegelased)
        {
            this.tegelased = tegelased;
        }

        public List<Tegelane> SuurimaEsemeteArvutega()
        {
            List<Tegelane> voitjad = new List<Tegelane>();
            Tegelane sorted = tegelased[0];
            foreach (Tegelane t in tegelased)
            {
                int num = sorted.CompareTo(t);
                if (num<0)
                {
                    sorted = t;
                    voitjad.Clear();
                }
                if (num==0)
                {
                    voitjad.Add(t);
                }
            }
            voitjad.Add(sorted);
            return voitjad;
        }

        public Tegelane suurmaPinktideArvuga()
        {
            int parim = 0;
            Tegelane voitjad = tegelased[0];
            foreach (var item in tegelased)
            {
                int arv = item.PunktideArv();
                if (arv > parim)
                {
                    parim = arv;
                    voitjad = item;
                }
            }
            return voitjad;
        }

    }
}
