using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cryptography.Analyzers
{
    public class TextAnalyzer
    {
        private TextAnalyzerResult result = new();

        public TextAnalyzerResult RunStatisticalAnalysis(string s)
        {
            CheckNull(s);
            result.TotalCharactersCount  = s.Length;

            return result;
        }

        public int GetWordCount(string s)
        {
            CheckNull(s);
            if(CheckEmpty(s))
                return 0;
            if(IsWhiteSpaceOnly(s)) 
                return 0;

            return s.Count(c => c == ' ') + 1;            
        }

        public int GetMinimumWordLength(string s)
        {
            int min = Int32.MaxValue;
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                if(word.Length < min)
                {
                    min = word.Length;
                }
            }
            return min;
        }

        public int GetMaximumWordLength(string s)
        {
            int max = 0;
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                }
            }
            return max;
        }

        private bool IsWhiteSpaceOnly(string s)
        {
            return s.All(x => x == ' ' || x == '\t');
        }

        private bool CheckEmpty(string s)
        {
            return s == String.Empty;
        }

        private static void CheckNull(string s)
        {
            if (s is null)
                throw new ArgumentNullException(nameof(s));
            return;
        }
    }
}