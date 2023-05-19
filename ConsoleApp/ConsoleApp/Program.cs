// See https://aka.mpublic class Solution {
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace InterviewQuestion
{
    
    public class Solution
    {
        public static void Main()
        { 
        }
        public bool isValid(string s)
        {
            Dictionary<char, char> openClose = new Dictionary<char, char>()
            {
                { ')' , '(' },
                { ']' , '[' },
                { '}' ,'{' }
            };
            List<char> control = new List<char>();
            if(s.Length > 0 )
            {
                foreach (char c in s)
                {
                    if (openClose.ContainsValue(c))
                    {
                        control.Add(c);
                        continue;
                    }
                    else if (openClose.ContainsKey(c))
                    {
                        if (control.Count == 0 || control[control.Count - 1] != openClose[c])
                        {
                            return false;
                        }
                        control.RemoveAt(control.Count - 1);
                        continue;
                    }
                    return false;
                }
                return control.Count == 0;

            }
            return false;
           
        }
    }


}

