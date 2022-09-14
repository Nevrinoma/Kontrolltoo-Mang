using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{

    class Peaklass
    {
        static Tegelane[] Mangijad(int tegelasekogus)
        {
            if (tegelasekogus < 2) throw new Exception();
            Tegelane[] mangijad = new Tegelane[tegelasekogus];
            for (int i = 0; i < tegelasekogus; i++)
            {
                Tegelane mangija = new Tegelane(Mangija_loetelu());
                mangijad[i] = mangija;
            }
            List<Ese> eseList = loeEsemed();
            if (eseList.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane m in mangijad)
            {
                Shuffle(eseList);
                int esedekogus = rnd.Next(2, 10);
                for (int i = 0; i < esedekogus; i++)
                {
                    m.liseEse(eseList[i]);
                }
            }
            return mangijad;
        }


        public static List<Ese> loeEsemed()
        {
            List<Ese> eseList = new List<Ese>();
            using (StreamReader from_file = new StreamReader(@"..\..\..\esemed.txt"))
            {
                while (!from_file.EndOfStream)
                {
                    string[] rida = from_file.ReadLine().Split(";");
                    Ese ese = new Ese(rida[0].ToString(),Int32.Parse(rida[1]));
                    eseList.Add(ese);
                }
            }
            return eseList;
        }
        
        static public void Uus_mang(int kogus)
        {
            Tegelane[] mangijad = Mangijad(kogus);
            Mang mang = new Mang(mangijad);
            foreach (Tegelane v in mang.SuurimaEsemeteArvutega())
            {
                Console.WriteLine(v.Info());
            }
            Tegelane voitja=mang.suurmaPinktideArvuga();
            Console.WriteLine(voitja.Info());
            Console.WriteLine("Mängijal olid järgmised esed: ");
            voitja.valjastaEsemed();
        } 

        public static void Shuffle<T> (CallConvThiscall IList<T> list)
        {
            int n = list.Count;
            while(n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }


        Tegelane one = new Tegelane("Naruto");
        Tegelane two = new Tegelane("Saske");


    }
}
