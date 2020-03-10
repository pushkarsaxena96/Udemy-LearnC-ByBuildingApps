using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // FOR USING FILES
using WordUnscrambler.cs.Workers;
using WordUnscrambler.cs.Data;



namespace WordUnscrambler.cs
{
    
    class Program
    {
        private const string wordListFileName = Constants.wordListFileName; // only assigned to builtin types
        private static readonly FileReader _fileReader =  new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher(); 
        static void Main(string[] args)
        {
            try
            {
                bool continueWordUnscramble = true;
                do
                {
                    Console.WriteLine(Constants.OptionsOnHowToEnterScrambledWords);
                    var option = Console.ReadLine() ?? string.Empty; // throw can be used in c#7

                    switch (option.ToUpper())
                    {
                        case Constants.File:
                            Console.WriteLine(Constants.EnterScrambledWordsViaFile);
                            ExecuteScrambledWordsInFile();
                            break;
                        case Constants.Manual:
                            Console.WriteLine(Constants.EnterScrambledWordsManually);
                            ExecuteScrambledWordsManualInput();
                            break;
                        default:
                            Console.WriteLine(Constants.EnterScrambledWordsOptionNotRecognized);
                            break;
                    }

                    var ContinueDecision = string.Empty;
                    do
                    {
                        Console.WriteLine(Constants.OptionsOncontinuingTheProgram);
                        ContinueDecision = (Console.ReadLine() ?? string.Empty);

                    } while (!ContinueDecision.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase)
                    && (!ContinueDecision.Equals(Constants.No, StringComparison.OrdinalIgnoreCase)));

                    continueWordUnscramble = ContinueDecision.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase);

                } while (continueWordUnscramble);

            }




            catch (Exception ex)
            {
                Console.WriteLine(Constants.ErrorProgramwillBeTermindated + ex.Message);
            }
            

            
        }

        private static void ExecuteScrambledWordsManualInput()
        {
            var manualinput = Console.ReadLine() ?? string.Empty;
            string[] scrambledwords = manualinput.Split(',');
            displayMatchedScrambledWords(scrambledwords);
        }

        private static void displayMatchedScrambledWords(string[] scrambledwords)
        {
            string[] wordList = _fileReader.Read(wordListFileName);
            List<MatchedWords> matchedWords = _wordMatcher.Match(scrambledwords, wordList);

            if (matchedWords.Any())
            {
                foreach (var matchedword in matchedWords)
                {
                    Console.WriteLine(Constants.MatchFound, matchedword.Scrambledwords, matchedword.Word);
                }
            }
            else
            {
                Console.WriteLine(Constants.MatchNotFound);
            }
        }

        private static void ExecuteScrambledWordsInFile()
        {
            var filename = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = _fileReader.Read(filename);
            displayMatchedScrambledWords(scrambledWords);
        }

    }
    
}        
    
