using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_2.Busines
{
    class Letter
    {

    }
    class word
    {
        private List<Letter> _letters = new List<Letter>();
        
        public int GetLetterCount()
        {
            return _letters.Count;
        }
    }

}
