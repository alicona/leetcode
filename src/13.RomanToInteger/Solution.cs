using System;
using System.Collections.Generic;

namespace _13.RomanToInteger
{
    public class Solution
    {
        public int RomanToInteger(string s)
        {
            var dictionary = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };

            var total = dictionary[s[s.Length-1]];
            var prevValue = total;
            

            for (int i = s.Length-2; i >= 0; i--)
            {
                var current = dictionary[s[i]];

                if(current >= prevValue)
                {
                    total += current;
                }else
                {
                    total -= current;
                }
                
                prevValue = current;
            }
            return total;
        }
    }
}
