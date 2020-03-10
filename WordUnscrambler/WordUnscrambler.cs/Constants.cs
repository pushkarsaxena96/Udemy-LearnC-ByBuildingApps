using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler.cs
{
    class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords = "Enter scrambled word(s) manually or as a file: F - file/ M - Manual";
        public const string OptionsOncontinuingTheProgram = "Would you like to continue? Y/N";
        public const string EnterScrambledWordsViaFile = "Enter full path including the file name";
        public const string EnterScrambledWordsManually = "Enter word(s) manually (separated by comma if multiple)";
        public const string EnterScrambledWordsOptionNotRecognized = "The Option was not recognized";
        public const string ErrorScrambledWordsCannotBeLoaded = "scrambled Words were not loaded because there was an error";
        public const string ErrorProgramwillBeTermindated = "the rogram will be terminated";
        public const string MatchFound = "Match Found for {0}: {1}";
        public const string MatchNotFound = "NO MATCHES FOUND";
        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";
        public const string wordListFileName = "listofwords.txt";

    }
}
