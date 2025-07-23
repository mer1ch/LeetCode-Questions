using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01. Two Sum

            //    public class Solution
            //{
            //    public int[] TwoSum(int[] nums, int target)
            //    {
            //        for (int i = 0; i < nums.Length; i++)
            //        {
            //            for (int j = 0; j < nums.Length; j++)
            //            {
            //                if (nums[i] + nums[j] == target)
            //                {
            //                    if (i != j)
            //                    {
            //                        return [i, j];
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //        return [0, 0];
            //    }
            //}

            #endregion

            #region 09. Palindrome

            //    public class Solution
            //{
            //    public bool IsPalindrome(int x)
            //    {
            //        bool isPalindrome = false;
            //        string s = x.ToString();
            //        for (int i = 0; i < s.Length; i++)
            //        {
            //            if (s[i] == s[(s.Length - 1) - i])
            //            {
            //                isPalindrome = true;
            //            }
            //            else
            //            {
            //                isPalindrome = false;
            //                break;
            //            }
            //        }
            //        return isPalindrome;
            //    }
            //}

            #endregion

            #region 13. Roman to Integer

        //    public class Solution
        //{
        //    public int RomanToInt(string s)
        //    {
        //        string test = "";
        //        int result = 0;
        //        char firstCharacter, secondCharacter;
        //        var set = new Dictionary<string, int>(){
        //    {"I",1},
        //    {"IV",4},
        //    {"V",5},
        //    {"IX",9},
        //    {"X",10},
        //    {"XL",40},
        //    {"L",50},
        //    {"XC",90},
        //    {"C",100},
        //    {"D",500},
        //    {"M",1000},
        //    {"CD",400},
        //    {"CM",900}
        //};
        //        for (int i = 0; i < s.Length; i++)
        //        {
        //            firstCharacter = s[i];
        //            if ((firstCharacter.Equals('I') || firstCharacter.Equals('X') || firstCharacter.Equals('C')) && i < s.Length - 1)
        //            {
        //                secondCharacter = s[i + 1];
        //                test = test + firstCharacter + secondCharacter;
        //                if (set.ContainsKey(test))
        //                {
        //                    result += set[test];
        //                    test = "";
        //                    i++;
        //                    continue;
        //                }
        //                test = "";
        //            }
        //            result += set[firstCharacter.ToString()];
        //        }
        //        return result;
        //    }
        //}

        #endregion
    }
    }
}
