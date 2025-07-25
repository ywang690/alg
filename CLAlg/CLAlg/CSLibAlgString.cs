using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAlg
{
    public class CSLibAlgString
    {
        public int LengthOfLastWord(string s)   //58
        {
            //string s1 = "Hello World";
            //string s2 = "   fly me   to   the moon  ";
            //string s3 = "luffy is still joyboy";
            //int output = LengthOfLastWord(s3);

            int _output = 0;
            Int32 Space = 0;
            Console.WriteLine(s.Length);
            Space = s.LastIndexOf(" ");
            Console.WriteLine(s.Substring(Space, (s.Length - Space)));
            return (s.Length - Space);
        }
        public string ReverseVowels(string s)   //345
        {
            string _output = "";
            return _output;
        }

        public void ReverseString(char[] s) //344
        {
            string _output = "";
            
            //_output = 
            //return _output;
            //Example 1:

            //Input: s = ["h", "e", "l", "l", "o"]
            //Output: ["o", "l", "l", "e", "h"]
            //Example 2:

            //Input: s = ["H", "a", "n", "n", "a", "h"]
            //Output: ["h", "a", "n", "n", "a", "H"]
        }

        public bool IsIsomorphic(string s, string t)    //205. Isomorphic Strings
        {
            bool _result = false;
            return _result;
        }

        public IList<IList<int>> Generate(int numRows)  //118. Pascal's Triangle
        {
            IList<IList<int>> _output = new List<IList<int>>();
            return _output;
        }

        public bool IsAnagram(string s, string t)
        {
            bool _result= false;
            return _result;
        }
        public bool SearchInsertPosition()  //35
        {
            bool _result = false;
            return _result;
        }
        public int LengthOfLastWord()  //58
        {
            int _LenOfLastWord = 0;
            return _LenOfLastWord;
        }
        public string LongestCommonPrefix() //14
        {
            string _LongestCommonPrefix = "";
            return _LongestCommonPrefix;
        }
        public string ReverseWordsinaString() //151
        {
            string _ReverseWordsinaString = "";
            return _ReverseWordsinaString;
        }
        public string ReverseWordsinaStringII() //186
        {
            string _ReverseWordsinaStringII = "";
            return _ReverseWordsinaStringII;
        }
        public string ReverseWordsinaStringIII() //557
        {
            string _ReverseWordsinaStringIII = "";
            return _ReverseWordsinaStringIII;
        }
        public int NumOfSegmentsInaString() //434
        {
            int _NumOfSegmentsInaString = 0;
            return _NumOfSegmentsInaString;
        }
        public string SmallestIndexWithEqualValue() //2057
        {
            string _SmallestIndexWithEqualValue = "";
            return _SmallestIndexWithEqualValue;
        }
        public bool ValidPalindrome()   //125
        { 
            bool _ValidPalindrome = false;
            return _ValidPalindrome;
        }
        public string BackspaceStringCompare()  //844
        {
            string _BackspaceStringCompare = "";
            return _BackspaceStringCompare;
        }
        public bool ValidPalindromeII() //680
        {
            bool _ValidPalindromeII = false;
            return _ValidPalindromeII;
        }

    }
}
