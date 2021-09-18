using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblem
{
    class Program
    {
        //Solution: TwoSum
        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> numberDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Count(); i++)
            {
                int output;

                if (numberDict.TryGetValue(target - nums[i], out output))
                {
                    return new int[] { i, output };
                } 

                if (!numberDict.ContainsKey(nums[i]))
                {
                    numberDict.Add(nums[i], i);
                }

            }
            return new int[] { 0, 0 };
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var line = Console.ReadLine();
            if (line == "quit")
            {
                return;
            }
        }
    }
}
