using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return 0;

            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length > str2.Length ? str2.Length : str1.Length);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;

            var sum = 0;
            foreach (var number in numbers)
                sum += number;

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;

            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                    sum += number;
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;

            var sum = 0;
            foreach (var number in numbers)
                sum += number;

            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;
            for (int i = 0; i < number; i++)
                if (i  % 2 != 0)
                    count++;

            return count;
        }
    }
}
