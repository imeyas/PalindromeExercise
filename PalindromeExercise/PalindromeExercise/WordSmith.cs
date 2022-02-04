using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public static bool IsAPalindrome(string word)
        {
            var reverse = "";

            for (var i = word.Length - 1; i >= 0; i--)
            {
                reverse += word.ToLower()[i];
            }

            if (reverse == word.ToLower())
            {

                return true;
            }
            else
            {
                return false;
            }


        }
    }
}

