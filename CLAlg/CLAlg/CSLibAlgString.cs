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

        public string ReverseString(char[] s) //344
        {
            string _output = "";
            Array.Reverse(s);
            
            _output = new string(s);
            
            //_output = 
            //return _output;
            //Example 1:

            //Input: s = ["h", "e", "l", "l", "o"]
            //Output: ["o", "l", "l", "e", "h"]
            //Example 2:

            //Input: s = ["H", "a", "n", "n", "a", "h"]
            //Output: ["h", "a", "n", "n", "a", "H"]
            return _output;
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
    }
}
