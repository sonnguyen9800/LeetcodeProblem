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

        //Solution: Reverse
        public int Reverse(int x)
        {
            int signed = x > 0 ? 1 : -1;
            x *= signed; // get abs value;

            string originalString = x.ToString();
            char[] strArray = originalString.ToCharArray();
            Array.Reverse(strArray);
            string reverse = new string(strArray);
            int val;
            if (int.TryParse(reverse, out val))
            {
                return val;
            };



            return 0;

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
