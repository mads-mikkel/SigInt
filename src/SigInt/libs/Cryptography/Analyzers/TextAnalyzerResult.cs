using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Analyzers
{
    public class TextAnalyzerResult
    {
        public int TotalCharactersCount { get; internal set; }
        public int WhiteSpaceCharactersCount { get; internal set; }
        public int WordCount { get; internal set; }

        public override string ToString()
        {
            string nl = Environment.NewLine;
            string s = $"Character count: {TotalCharactersCount:N0}{nl}" +
                $"Word count: {WordCount:N0}{nl}";
            return s;
        }
    }
}
