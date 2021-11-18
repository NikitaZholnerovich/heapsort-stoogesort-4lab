using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab4_PPVS_
{
    public class RandomGenerator
    {
        private const int MAX_VALUE = 1000;
        private const int NUMBER_OF_ITEMS = 10;
        private const string DICTIONARY_FILE_NAME = "Dictionary.txt";

        public int[] GenerateRandomIntArray()
        {
            var random = new Random();

            var randmonArray = new List<int>();

            for (var i = 0; i < NUMBER_OF_ITEMS; i++)
            {
                randmonArray.Add(random.Next(MAX_VALUE));
            }

            return randmonArray.ToArray();
        }

        public string[] GenerateRandomWordsArray()
        {
            var randomPositions = GenerateRandomIntArray();

            var lines = File.ReadAllLines(DICTIONARY_FILE_NAME);

            var randomWords = randomPositions.Select(p => lines[p]);

            return randomWords.ToArray();

        }
    }
}
