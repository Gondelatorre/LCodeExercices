using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class ContainsDuplicateProblem : IProblem
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

        internal static ContainsDuplicateProblem Create()
        {
            return new ContainsDuplicateProblem();
        }


        public void Resolve()
        {

            Console.WriteLine("La solución al problema Contains duplicate");


            int[] nums = new int[] { 5, 1, 3, 4, 2, 5 };

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
            HashSet<int> d = new HashSet<int>();


            for (int i = 0; i < nums.Length; i++)
            {

                if (!d.Add(nums[i])) return true;
            }

            return false;
        }



        /// <summary>
        /// Solución lenta
        /// </summary>
        //public bool ContainsDuplicateOriginal(int[] nums)
        //{
        //    if (nums.Length == 1) return false;

        //    Array.Sort(nums);



        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        if (nums[i] == nums[i - 1])
        //            return true;
        //    }

        //    return false;
        //}


    }
}
