using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AnagramFinder
{
    public class AnagramFinder 
    {
        /**
         * Takes a list of strings and returns a list of lists containing all the anagram matches
         * found in the list of strings. This version does not take repeat chars into account
         * and will group all words with the same unique chars together.
         */
        public List<List<string>> Finder(List<string> wordList) 
        {
            int counter = 0;

            Dictionary<string, int> anagramMatches = new Dictionary<string, int>();

            List<List<string>> resultList = new List<List<string>>();

            wordList.Sort();

            // Add words with unique char matches to corresponding list, if no lists match
            // then create a new list for it and add its unique chars to dictionary.
            foreach (var word in wordList)
            {
                if (anagramMatches.ContainsKey(GetUniqueChars(word)))
                {
                    resultList[anagramMatches[GetUniqueChars(word)]].Add(word);
                }
                else
                {
                    resultList.Add(new List<string>{word});
                    anagramMatches.Add(GetUniqueChars(word),counter);
                    counter++;
                }
            }

            //Delete any lists with only 1 value
            for (int i = 0; i < resultList.Count; i ++)
            {
                if (resultList[i].Count < 2)
                {
                    resultList.Remove(resultList[i]);
                }
            }

            //Sort our lists Alphabetically
            foreach (var list in resultList)
            {
                list.Sort();
            }


            return resultList;
        }

        /**
         * Takes in a string and returns all the unique characters found in that string.
         */
        public string GetUniqueChars(string s)
        {
            s = s.ToLower();

            char[] charList = s.ToCharArray();
            Array.Sort(charList);

            StringBuilder builder = new StringBuilder();

            foreach (char ch in charList)
            {
                if (!builder.ToString().Contains(ch))
                {
                    builder.Append(ch);
                }
            }

            return builder.ToString();
        }
    }
}