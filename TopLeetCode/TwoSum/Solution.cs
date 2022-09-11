using System;
using System.Collections.Generic;
namespace Competitive_programming_in_C_Sharp.TopLeetCode
{
    public static class TwoSum
    {
        public static int[] SolveTwosum(int[] nums,int target)
        {
            //Dictionary is similar to hashmap in java. It takes O(1) to search a value using key.
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                //first we are cheking whether target-nums[i] does exist in map or not. In takes O(1).
                if (map.ContainsKey(target-nums[i])) return new int[] { i,map[target-nums[i]] };
                //Dictionary throws runtime errors on trying to add same key twice. So better to check it first. 
                if (!map.ContainsKey(nums[i]))
                map.Add(nums[i],i);
            }
            //if combination is not possible return -1,-1.
            return new int[]{-1,-1};
        }
    }
}
