using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really really really really long text.... much like recipe inspirations online.";
            const int maxLength = 20;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                //sentence.Substring(0, maxLength); this could cut off as word
                //break sentence into words:
                var words = sentence.Split(' ');//string array of words
                var totalCharacters = 0;
                var summaryWords = new List<string>(); 
                //loop over array of words.
                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length +1;

                    if (totalCharacters>maxLength)
                    {
                        break;
                    }
                }

                var summary = String.Join(" ", summaryWords)+ "...";
                Console.WriteLine(summary);
            }
        }

       

    }
}
