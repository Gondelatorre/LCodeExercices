using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class ContainsDuplicateProblem2 : IProblem
    {

        /*
                https://leetcode.com/problems/contains-duplicate/
          
         
                 Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct. 

                Example 1:

                    Input: nums = [1,2,3,1]
                    Output: true

                Example 2:

                    Input: nums = [1,2,3,4]
                    Output: false

                Example 3:

                    Input: nums = [1,1,1,3,3,4,3,2,4,2]
                    Output: true
 

                Constraints:

                1 <= nums.length <= 105
                -109 <= nums[i] <= 109

        */

        internal static ContainsDuplicateProblem2 Create()
        {
            return new ContainsDuplicateProblem2();
        }

        public void Resolve()
        {

            Console.WriteLine("La solución al problema Contains duplicate");


            int[] nums = new int[] { 1, 2, 3, 4 };

            Console.Write($"listado: ");
            foreach (int i in nums)
            {
                Console.Write($"{i}, ");
            }


            bool result = ContainsDuplicate(nums);

            Console.WriteLine($"=>  Respuesta: {result}");
        }



        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 1) return false;
                        
            HashSet<int> d = new HashSet<int>();


            for (int i = 0; i < nums.Length; i++)
            {

                if (d.Contains(nums[i]))
                {
                    return true;
                } else
                {
                    d.Add(nums[i]);
                }

            }

            return false;
        }


    }
}
