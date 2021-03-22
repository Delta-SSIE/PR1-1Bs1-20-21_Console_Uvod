using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069b_Objekty_a_pole
{
    class Postava
    {
        public string Jmeno;
        public Rasa Rasa;
        public string[] OblibenaJidla;
        public int[] StastnaCisla;

        public string SeznamJidel()
        {
            return string.Join(", ", OblibenaJidla);
        }
    }
}
