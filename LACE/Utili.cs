using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LACE
{
    class Utili
    {
        public Utili()
        { }


        public static double getFrequencySum(List<word> words)
        {
            double sum = 0;
            for (int i = 0; i < words.Count; i++)
                sum += words[i].frequency;

            return sum;
        }

        public static double getBirthSum(List<word> words)
        {
            double sum = 0;
            for (int i = 0; i < words.Count; i++)
                if (words[i].isnew)
                    sum++;

            return sum;
        }

        public static List<word> loadFrequencyData(string file)
        {
            List<word> words = new List<word>();
            StreamReader frequencyFile = new StreamReader(file);

            string line;

            while (!frequencyFile.EndOfStream)
            {
                line = frequencyFile.ReadLine();

                try
                {
                    words.Add(new word(line.Split(' ')[0], Convert.ToInt32(line.Split(' ')[1]), Convert.ToBoolean(line.Split(' ')[2])));
                }
                catch
                {

                }
            }


            return words;

        }


    }
}
