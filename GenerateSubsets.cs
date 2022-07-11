using System;
using System.Collections.Generic;

namespace Competitive_programming_in_C_Sharp
{
    public static class Subsets
    {
        //[A,B,C]->   []  [A][B] [C][A,B][A,C][B,C][A,B,C]
        //[000-111]->000,100,010,001,110,101,011,111
        //[0-7]->     0,  4,  2,  1,  6,  5,  3   7
        //Above exapmle shows there is total 8 possible subsets from 3 elemnets
        //we can simply calculate this by 2^totalElements
        public static List<String> generateAllSubsets(char[] set)
        {
            List<String> subsets = new List<string>();
            int NoOfElements = set.Length;
            int totalPossibleSubsets = 1 << NoOfElements; //1<<NoOfElements= 2^NoOfElements
            for (int i = 0; i < totalPossibleSubsets; i++)
            {
                String subset = "{";
                
                for (int j = 0; j < NoOfElements; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        subset += set[j].ToString() + " ";
                    }
                }
                subset += "}";
                Console.WriteLine(subset);//print each subset
                subsets.Add(subset);
            }
            return subsets;
        }
    }
}
