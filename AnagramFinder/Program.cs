using System;
using System.Collections.Generic;

namespace AnagramFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramFinder af = new AnagramFinder();

            List<string> wordList = new List<string>{ "cab","aaa", "abc","cbbbba","a","qwer"};

            List<List<string>> resultList = af.Finder(wordList);

            foreach (var list in resultList)
            {
                Console.WriteLine("************");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            
            

            Console.WriteLine();
        }
    }
}
