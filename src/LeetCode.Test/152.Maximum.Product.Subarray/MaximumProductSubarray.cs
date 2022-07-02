using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class MaximumProductSubarray : IProblem
    {
        /*
                152. Maximum Product Subarray
            

                Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.

                The test cases are generated so that the answer will fit in a 32-bit integer.

                A subarray is a contiguous subsequence of the array.

 

                Example 1:

                Input: nums = [2,3,-2,4]
                Output: 6
                Explanation: [2,3] has the largest product 6.
                Example 2:

                Input: nums = [-2,0,-1]
                Output: 0
                Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
 

                Constraints:

                1 <= nums.length <= 2 * 104
                -10 <= nums[i] <= 10
                The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
        */


        internal static MaximumProductSubarray Create()
        {
            return new MaximumProductSubarray();
        }


        public void Resolve()
        {
            //int[] nums = new int[] { 2, 3, -2, 4 };
            int[] nums = new int[] { -2, 0, -1 };
            //int[] nums = new int[] { -2 };
            //int[] nums = new int[] { 3, -1, 4 };
            //int[] nums = new int[] { -1, -2, -3, 0};
            //int[] nums = new int[] { 1, 0, -1, 2, 3, -5, -2 };
            //int[]  nums = new int[] { -2, 1, 0 };
            


            Console.Write($"Números: ");
            foreach (int i in nums)
            {
                Console.Write($"{i}, ");
            }


            int result = MaxProduct(nums);

            Console.WriteLine($"=> Respuesta: {result} ");


        }


        public int MaxProduct(int[] nums)
        {

            int max = int.MinValue;
            int neg = 1;
                        
            int p = 1;
            int t = 0;
            int c = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                t = p;
                c++;
                
                if (neg == 1 && p < 0) 
                    neg = p;
                               

                p = p * nums[i];
                
                if (p > max)
                    max = p;


                if (p == 0)
                {
                    if (t < 0 && c > 2)
                    {
                        p = t / neg;

                        if (p > max) max = p;
                    }

                    p = 1;
                    neg = 1;
                    c = 0;
                }


            }

            if (p < 0 && neg < 0)
            {
                t = p / neg;

                if (t > max)
                    max = t;
            }


            return max;


        }
    }
}
