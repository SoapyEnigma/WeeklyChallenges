using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
                if (val == false)
                    return true;

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;

            int i = 0;
            foreach (int val in numbers)
                if (val % 2 != 0)
                    i += val;

            if (i % 2 != 0)
                return true;

            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (!hasUpper && char.IsUpper(c))
                {
                    hasUpper = true;
                    continue;
                }

                if (!hasLower && char.IsLower(c))
                {
                    hasLower = true;
                    continue;
                }

                if (!hasNumber && char.IsNumber(c))
                    hasNumber = true;
            }

            if (hasUpper && hasLower && hasNumber)
                return true;

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> result = new List<int>();

            for (int i = 0; i < 100; i++)
                if (i % 2 != 0)
                    result.Add(i);

            return result.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
