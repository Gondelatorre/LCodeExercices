using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class SearchRotateSortArray : IProblem
    {

        /*
            33. Search in Rotated Sorted Array

            There is an integer array nums sorted in ascending order (with distinct values).

            Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) 
            such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). 
            For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].

            Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

            You must write an algorithm with O(log n) runtime complexity.

            Example 1:

            Input: nums = [4,5,6,7,0,1,2], target = 0
            Output: 4
            Example 2:

            Input: nums = [4,5,6,7,0,1,2], target = 3
            Output: -1
            Example 3:

            Input: nums = [1], target = 0
            Output: -1


            Constraints:

            1 <= nums.length <= 5000
            -104 <= nums[i] <= 104
            All values of nums are unique.
            nums is an ascending array that is possibly rotated.
            -104 <= target <= 104
        */



        public void Resolve()
        {

            int[] nums = new int[] { 4, 5, 6, 7, 8, 1, 2, 3 };
            int target = 8;


            Console.Write($"Números: ");
            foreach (int i in nums)
            {
                Console.Write($"{i}, ");
            }

            Console.Write($"Target: {target}");

            int result = Search(nums, target);

            Console.WriteLine($"=> Respuesta: {result}");

        }

        public int Search(int[] nums, int target)
        {

            int pos = -1;

            int i = 0;
            int f = nums.Length - 1;

            while (true)
            {
                int m = Convert.ToInt32((f - i) / 2) + i;


                if (nums[i] == target)
                {
                    pos = i;
                    break;
                }
                
                if (nums[m] == target)
                {
                    pos = m;
                    break;
                }

                if (nums[f] == target)
                {
                    pos = f;
                    break;
                }

                if (i == f || m == i)
                {
                    break;
                }

                if (nums[i] <= nums[m])
                {
                    if (nums[i] <= target && target <= nums[m])
                    {
                        f = m;
                        continue;
                    }

                }
                else
                {
                    if (nums[i] >= target && target <= nums[m] || nums[i] <= target && target >= nums[m])
                    {
                        f = m;
                        continue;
                    }
                }

                if (nums[m] < nums[f])
                {
                    if (nums[m] <= target && target <= nums[f])
                    {
                        i = m;
                        continue;
                    }
                }
                else
                {
                    if (nums[m] >= target && target <= nums[f] || nums[m] <= target && target >= nums[f])
                    {
                        i = m;
                        continue;
                    }
                }
                break;
            }

            return pos;
        }


    }
}
