using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordUnscrambler.cs.Data;

namespace WordUnscrambler.cs.Workers
{
    public class WordMatcher
    {
        public List<MatchedWords> Match(string[] scrambledwords, string[] wordList)
        {
            var matchedwords = new List<MatchedWords>();
            foreach (var scrambledword in scrambledwords)
            {
                foreach (var word in wordList)
                {
                    if (scrambledword.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedwords.Add(BuildMatchedWord(scrambledword, word));
                    }
                    else
                    {
                        var scrambledWordArray = scrambledword.ToCharArray();
                        var wordarray = word.ToCharArray();
                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordarray);

                        var sortedScrambledWord = new string(scrambledWordArray);
                        var sortedWord = new string(wordarray);

                        if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedwords.Add(BuildMatchedWord(scrambledword, word));
                        }
                    }
                }
            }


            return matchedwords;
        }

        private MatchedWords BuildMatchedWord(string scrambleWord, string word)
        {
            MatchedWords matchedWord = new MatchedWords()
            {
                Scrambledwords = scrambleWord,
                Word = word
            };

                return matchedWord;
        }
    }


}

