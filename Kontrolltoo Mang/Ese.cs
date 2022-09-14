using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_Mang
{
    internal class Ese : IUksus
    {
        private string nimetus;
        private int punktideArv;

        public string Info()
        {
            Console.WriteLine(nimetus);
            return nimetus;
        }

        public int PunktideArv()
        {
            return punktideArv;
        }

        public Ese(string nimetus, int punktideArv)
        {
            this.nimetus = nimetus;
            this.punktideArv = punktideArv;
        }

    }


}
