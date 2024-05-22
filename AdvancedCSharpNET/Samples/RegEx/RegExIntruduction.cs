using System;
using System.Text.RegularExpressions;

namespace AdvancedCSharp.Samples.RegEx
{
    class RegExIntruduction
    {
        const string AddressCodePattern = @"\b\d{2}-\d{3}\b"; //"(\d{1,2}|1\d{2}|2[0-4]\d{1}|25[0-5]{1})\."  "\d{1,3}"   333.333.
        //const string AddressCodePattern = @"\b[0-9]{2}-[0123456789]{3}\b";
        const string HtmlTagsPatternGreedy = "<.+>";
        const string HtmlTagsPatternLazy = "<.+?>";
        //"[A-Za-z]"
        static void Main()
        {
            Regex regex = new Regex(AddressCodePattern);
            //regex.Options 
            var inputSentence = "Mój kod poc00-000ztowy to 00-001 w Warszawie  100-001=99";
            Regex.Match(inputSentence, AddressCodePattern);
            var match = regex.Matches(inputSentence);
            if (match[0].Success)
            {
                Console.WriteLine(match[0].Value);
            }

            var htmlPartString = @"<body> Hello World </body>";
            var greedyMatches = Regex.Matches(htmlPartString, HtmlTagsPatternGreedy);
            var lazyMatches = Regex.Matches(htmlPartString, HtmlTagsPatternLazy);
            Console.WriteLine("Looking for matches of sentence pattern: {0}", htmlPartString);
            Console.WriteLine("Greedy pattern - matches: {0}\t matches are {1}", greedyMatches.Count, greedyMatches[0]);
            Console.WriteLine("Lazy pattern - matches: {0}\t matches are {1}, {2}", lazyMatches.Count, lazyMatches[0], lazyMatches[1]);

            //Regex.CacheSize - when used
            
            Console.ReadKey();
        }

    }
}
