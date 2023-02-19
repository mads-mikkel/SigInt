using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Analyzers
{
    public class TextAnalyzerResult
    {
        public TextAnalyzerResult() { }
        public TextAnalyzerResult(Dictionary<string, int> wordOccurrences) 
        {
            WordOccurrences = ProcessWordOccurences(wordOccurrences);
        }

        public int TotalCharactersCount { get; internal set; }
        public int WhiteSpaceCharactersCount { get; internal set; }
        public int WordCount { get; internal set; }
        public string WordOccurrences { get; private set; }

        private string ProcessWordOccurences(Dictionary<string, int> wordOccurrences)
        {
            string s = $"Word occurrences:{Environment.NewLine}", line = String.Empty;
            int i = 1;
            foreach (var kv in wordOccurrences) 
            {
                line = $" {i++,5}: ({kv.Value})  {kv.Key}{Environment.NewLine}";
                s += line;
            }
            return s;
        }

        public override string ToString()
        {
            string nl = Environment.NewLine;
            string s = $"Character count: {TotalCharactersCount:N0}{nl}" +
                $"Word count: {WordCount:N0}{nl}" + 
                WordOccurrences;
            return s;
        }
    }
}
