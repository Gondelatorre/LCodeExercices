using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class TwoSumProblem : IProblem
    {

        /*
        1. Two Sum

        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.

 

        Example 1:

        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        Example 2:

        Input: nums = [3,2,4], target = 6
        Output: [1,2]
        Example 3:

        Input: nums = [3,3], target = 6
        Output: [0,1]
 

        Constraints:

        2 <= nums.length <= 10 x4
        -10 x9 <= nums[i] <= 10 x9
        -10 x9 <= target <= 10 x9
        Only one valid answer exists.
 

        Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
         
         
         */


        internal static TwoSumProblem Create()
        {
            return new TwoSumProblem();
        }


        public void Resolve()
        {

            Console.WriteLine("La solución al problema 1. Two sum");


            //int[] nums = new int[] { 2, 5, 11, 15, 7, 8  };
            //int target = 9;

            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
           

            Console.Write($"listado: ");
            foreach (int i in nums)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine($"Target: {target}");


            int[] result = TwoSum(nums, target);

            Console.WriteLine($"=>  Respuesta: ");
            foreach (int i in result)
            {
                Console.Write($"{i}, ");
            }
        }


        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> d = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)
            {
                int v =  nums[i];

                if (d.ContainsKey(v))
                {
                    return new int[2] { d[v], i };
                }
                else  {
                    
                    d.TryAdd(target - v, i);
                }

            }
            return null;

        }
    }
}
