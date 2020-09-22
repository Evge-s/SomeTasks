using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CertTasks.Tasks
{
    class Task14
    {
        public static string text = "Rykacze is a village in Poland. The administrative district of Gmina Zambrów, " +
            "within Zambrów County, Podlaskie Voivodeship, in north-eastern Poland. Village";

        public static IEnumerable GetUniqueWords(string text)
        {
            return text.Split(new char[] { ',', '.', ' ', '!' }).GroupBy(g => g).Where(g => g.Count() == 1).Select(g => g.Key);
        }

        public static IEnumerable uniqWords(string text)
        {
            return from word in text.Split(new char[] { ' ', ',', '.', '!' })
                   group word by word into box
                   where box.Count() == 1
                   select box.Key;
        }
    }
}
