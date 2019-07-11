using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFeaturesPractice
{
    public class Chain
    {
        public string outputText { get; set; }
        public int outputInt { get; set; }

        public Chain(string text, int num)
        {
            outputText = text;
            outputInt = num;
        }

        public Chain(string text) : this(text, 10)
        {
        }
          

        
    }
}
