using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class ProductOfArrayExceptSelf : IProblem
    {

        /*
            238. Product of Array Except Self 
         
            url: https://leetcode.com/problems/product-of-array-except-self/


            Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

            The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

            You must write an algorithm that runs in O(n) time and without using the division operation.

 

            Example 1:

            Input: nums = [1,2,3,4]
            Output: [24,12,8,6]
            Example 2:

            Input: nums = [-1,1,0,-3,3]
            Output: [0,0,9,0,0]
 

            Constraints:

            2 <= nums.length <= 105
            -30 <= nums[i] <= 30
            The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 

            Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)
                  
                  
        */


        internal static ProductOfArrayExceptSelf Create()
        {
            return new ProductOfArrayExceptSelf();
        }

        public void Resolve()
        {
            //int[] nums = new int[] { 1, 2, 3, 4 };
            int[] nums = new int[] { -1, 1, 0, -3, 3 };

            Console.Write($"Números: ");
            foreach (int i in nums)
            {
                Console.Write($"{i}, ");
            }

            
            int[] result = ProductExceptSelf(nums);

            Console.WriteLine($"=> Respuesta:  ");
            foreach (int i in result)
            {
                Console.Write($"{i}, ");
            }
        }

        

        public int[] ProductExceptSelf(int[] nums)
        {


            int[] result = new int[nums.Length];
            int cc = 0;
            int i = 0;
            int t = 1;


            Calcular(ref nums, ref cc, ref result, i, nums.Length,  t);

            return result;
        }


        public int Calcular(ref int[] nums, ref int cc, ref int[] result,int i, int max, int t)
        {
            int m;
            int tn;
            if (i < max)
            {
                tn = nums[i];
                if (nums[i] == 0)
                {
                    cc++;
                    tn = 1;
                }
                i++;
                t = t * tn;
                m =   Calcular(ref nums, ref cc, ref result,  i , max,  t);
            } else
            {
                return t;
            }

            i--;
            if (cc > 1 || (cc == 1 && nums[i] != 0) )
            {
                result[i] = 0;

            } else
            {
                result[i] = Convert.ToInt32(m * Math.Pow(tn, -1));
            }


            return m;
        }



    }
}
