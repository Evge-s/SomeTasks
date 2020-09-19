using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task14
    {
       public static string text = "Rykacze is a village in Poland. The administrative district of Gmina Zambrów, " +
            "within Zambrów County, Podlaskie Voivodeship, in north-eastern Poland. Village";
        public static IEnumerable uniqWords(string text)
        {
            return from word in text.Split(new char[] { ' ', ',', '.', '!' })
                   group word by word into box
                   where box.Count() == 1
                   select box.Key;
        }


    }
}
