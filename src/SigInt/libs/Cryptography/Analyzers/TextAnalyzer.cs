using System;
using System.Collections.Generic;
//using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Cryptography.Analyzers
{
    public class TextAnalyzer
    {
        private TextAnalyzerResult result;

        public TextAnalyzerResult RunStatisticalAnalysis(string s)
        {
            CheckNull(s);
            result = new TextAnalyzerResult(GetWordOccurences(s));
            result.TotalCharactersCount = s.Length;
            result.WordCount = GetWordCount(s);

            return result;
        }

        public int GetWordCount(in string input)
        {
            CheckNull(input);
            if (CheckEmpty(input))
                return 0;
            if (IsWhiteSpaceOnly(input))
                return 0;

            bool state = false;
            int wordCount = 0;
            char nl = Environment.NewLine.ToCharArray().FirstOrDefault();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' || input[i] == nl || input[i] == '\t')
                {
                    state = false;
                }
                else if (!state)
                {
                    state = true;
                    wordCount++;
                }
            }
            return wordCount;
        }

        /// <summary>
        /// Gets a sorted key-value list of word occurences.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Dictionary<string, int> GetWordOccurences(in string input)
        {
            Dictionary<string, int> freq = new();
            string[] words = input.Split(' ', Environment.NewLine.ToCharArray().FirstOrDefault());
            foreach (string word in words)
            {
                if (freq.ContainsKey(word))
                {
                    freq[word]++;
                }
                else
                {
                    freq.Add(word, 1);
                }
            }
            IOrderedEnumerable<KeyValuePair<string, int>> sortedDictionary = freq.OrderByDescending(kv => kv.Value).ThenBy(kv => kv.Key);
            return new Dictionary<string, int>(sortedDictionary);
        }

        public int GetMinimumWordLength(string s)
        {
            int min = Int32.MaxValue;
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                if (word.Length < min)
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