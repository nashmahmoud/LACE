using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LACE
{
    class word : IComparable<word>
    {
        public string text;
        public int frequency;
        public bool isnew;

        public word(string Text, int Frequency, bool isNew)
        {
            text = Text;
            frequency = Frequency;
            isnew = isNew;

        }

        public int CompareTo(word other)
        {
            return -1 * frequency.CompareTo(other.frequency);
        }


    }
}
