using System;
using System.Linq;


namespace LIC_Palindrome_Indicator
{
    public class PalindromeChecker
    {
        private string _input = string.Empty;

        public PalindromeChecker(string value)
        {
            _input = value;        
        }

        public bool IsPalindrome()
        {
            return CheckPalindrome();
        }

        public bool IsAnagram()
        {
            return CheckAnagramOfPalindrome();
        }

        public bool IsAnagramOrPalindrome(out string result)
        {
            result = string.Empty;
            
            if (CheckPalindrome())
            {
                result = "a palindrome";
                return true;
            }

            if (CheckAnagramOfPalindrome())
            {
                result = "an anagram of a palindrome";
                return true;
            }
            
            result = "neither";
            return false;
        }
        
        private Boolean CheckPalindrome()
        { 
            if(string.IsNullOrEmpty(_input))
            {
                return false;
            }

            var result = true;
            
            var inputReverseOrder = new string(_input.Reverse().ToArray());

            if (_input == inputReverseOrder)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        private bool CheckAnagramOfPalindrome()
        {
            var result = true;

            var charOddAppearList = _input.GroupBy(i => i).Where(c => Tools.IsOdd(c.Count())).ToList();

            if (charOddAppearList.Count() > 1)
            {
                result = false;
            }

            return result;
        }
    }
}
