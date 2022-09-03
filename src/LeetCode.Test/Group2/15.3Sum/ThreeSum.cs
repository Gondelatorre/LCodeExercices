using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class ThreeSum : IProblem
    {

        /*
            15. 3Sum

            Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

            Notice that the solution set must not contain duplicate triplets.

 

            Example 1:

            Input: nums = [-1,0,1,2,-1,-4]
            Output: [[-1,-1,2],[-1,0,1]]
            Explanation: 
            nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
            nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
            nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
            The distinct triplets are [-1,0,1] and [-1,-1,2].
            Notice that the order of the output and the order of the triplets does not matter.
            Example 2:

            Input: nums = [0,1,1]
            Output: []
            Explanation: The only possible triplet does not sum up to 0.
            Example 3:

            Input: nums = [0,0,0]
            Output: [[0,0,0]]
            Explanation: The only possible triplet sums up to 0.
 

            Constraints:

            3 <= nums.length <= 3000
            -105 <= nums[i] <= 105


         */


        public void Resolve()
        {

            //[-1,0,1,2,-1,-4,-2,-3,3,0,4]
            //int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            //int[] nums = new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 };
            int[] nums = new int[] { 0, 0, 0, 0 };




            Console.Write($"Números: ");
            foreach (int i in nums)
            {
                Console.Write($"{i}, ");
            }



            IList<IList<int>> result = ThreeSumS(nums);

            Console.WriteLine($"=> Respuesta: ");

            foreach (var item in result)
            {
                Console.WriteLine($"R = {string.Join(",", item)}");
            }

        }


        public IList<IList<int>> ThreeSumS(int[] nums)
        {
            int id1, id2, id3;
            IList<IList<int>> res = new List<IList<int>>();
            int el = nums.Length;
            id3 = el;

            Array.Sort(nums);

            for (id1 = 0; id1 < el - 2; id1++)
            {

                if (id1 > 0 && nums[id1] == nums[id1 - 1])
                    continue;


                id2 = id1 + 1;
                id3 = el - 1;

                while (id2 < id3)
                {
                    int s = nums[id1] + nums[id2] + nums[id3];
                    if (s == 0)
                    {
                        res.Add(new List<int> { nums[id1], nums[id2], nums[id3] });

                        id3--;

                        while (id2 < id3 && nums[id3] == nums[id3 + 1])
                            id3--;
                    }
                    else if (s > 0)
                        id3--;
                    else
                        id2++;

                }

            }

            return res;

        }


        //public IList<IList<int>> ThreeSumS(int[] nums)
        //{


        //    SortedDictionary<int, List<int>> d = new SortedDictionary<int, List<int>>();
        //    IList<IList<int>> r = new List<IList<int>>();
        //    Dictionary<string, int> result = new Dictionary<string, int>();


        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (d.ContainsKey(nums[i]))
        //        {
        //            d[nums[i]].Add(i);
        //        }
        //        else
        //        {
        //            d.Add(nums[i], new List<int>() { i });
        //        }
        //    }


        //    foreach (var i1 in d)
        //    {
        //        int k1 = i1.Key;

        //        foreach (var i2 in d)
        //        {
        //            int k2 = i2.Key;

        //            if (k1 == k2)
        //            {
        //                if (d[k1].Count == 1)
        //                    continue;
        //            }

        //            int f = (k1 + k2) * -1;

        //            if (d.ContainsKey(f))
        //            {

        //                if (k1 == f || k2 == f)
        //                    if (d[f].Count == 1)
        //                        continue;

        //                if (k1 == 0 && k2 == 0)
        //                    if (d[0].Count < 3)
        //                        continue;



        //                List<int> nl = new List<int> { k1, k2, f };
        //                nl.Sort();

        //                if (result.ContainsKey(String.Join("",nl)))
        //                {
        //                    continue;
        //                }
        //                result.Add(String.Join("", nl), 0);
        //                r.Add(nl);


        //            }

        //        }

        //    }

        //    return r;

        //}
    }
}
