using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{


    internal class Peaklass
    {
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




    }
}
