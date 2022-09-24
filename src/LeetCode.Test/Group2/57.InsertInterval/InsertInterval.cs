using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Group2.InsertInterval
{
    internal class InsertInterval : IProblem
    {


        /*
            You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end 
            of the ith interval and intervals is sorted in ascending order by starti. You are also given an interval newInterval = [start, end] 
            that represents the start and end of another interval.

            Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have 
            any overlapping intervals (merge overlapping intervals if necessary).

            Return intervals after the insertion.

 

            Example 1:

            Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
            Output: [[1,5],[6,9]]
            Example 2:

            Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
            Output: [[1,2],[3,10],[12,16]]
            Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
 

            Constraints:

            0 <= intervals.length <= 104
            intervals[i].length == 2
            0 <= starti <= endi <= 105
            intervals is sorted by starti in ascending order.
            newInterval.length == 2
            0 <= start <= end <= 105

        */



        public void Resolve()
        {
            //int[] newInterval = new int[] { 2, 5 };
            //int[][] intervals = new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } };

            //int[] newInterval = new int[] { 2, 3 };
            //int[][] intervals = new int[][] { new int[] { 1, 5 } };

            //int[] newInterval = new int[] { 2, 7 };
            //int[][] intervals = new int[][] { new int[] { 1, 5 } };

            //int[] newInterval = new int[] { 2, 7 };
            //int[][] intervals = new int[][] { };

            //int[] newInterval = new int[] { 6, 8 };
            //int[][] intervals = new int[][] { new int[] { 1, 5 } };

            //int[] newInterval = new int[] { 0, 3 };
            //int[][] intervals = new int[][] { new int[] { 1, 5 } };



            //int[] newInterval = new int[] { 6, 8 };
            //int[][] intervals = new int[][] { new int[] { 1, 5 }, new int[] { 10, 11 } };

            int[] newInterval = new int[] { 3,4 };
            int[][] intervals = new int[][] { new int[] { 0, 5 }, new int[] { 8, 9 } };


            Console.WriteLine($"Insert interval [{newInterval[0]},{newInterval[1]}] ");
            Console.WriteLine($" Intervals: ");

            foreach (int[] i in intervals)
            {
                Console.Write($"[{i[0]},{i[1]}], ");

            }

            Console.WriteLine("");



            int[][] result = Insert(intervals, newInterval);

            Console.WriteLine($"=> Respuesta: ");
            foreach (int[] i in result)
            {
                Console.Write($"[{i[0]},{i[1]}], ");

            }
        }


        public int[][] Insert(int[][] intervals, int[] newInterval)
        {

            int i = 0;
            bool o = false;
            bool c = false;

            int[] ne = new int[] { newInterval[0], newInterval[1] };
            List<int[]> nI = new List<int[]>();


            while (i < intervals.Length)
            {
                int[] el = intervals[i];

                if (!o)
                {

                    if (ne[1] < el[0])
                    {
                        nI.Add(ne);
                        c = true;
                        break;
                    }

                    if (el[1] < ne[0])
                    {
                        nI.Add(el);
                        i++;
                        continue;
                    }

                    if (el[0] <= ne[0] && ne[0] <= el[1])
                    {
                        ne[0] = el[0];
                        o = true;
                    }

                    if (el[0] <= ne[1] && ne[1] <= el[1])
                    {
                        ne[1] = el[1];
                        o = true;
                        c = true;
                        nI.Add(ne);
                        i++;
                        break;
                    }

                    i++;
                    continue;
                }
                else
                {

                    if (ne[1] < el[0])
                    {
                        nI.Add(ne);
                        c = true;
                        break;
                    }

                    if (el[1] < ne[1])
                    {
                        i++;
                        continue;
                    }

                    if (ne[1] <= el[1])
                    {
                        ne[1] = el[1];
                        nI.Add(ne);
                        c = true;
                        i++;
                        break;
                    }
                }
            }

            if (!c)
            {
                nI.Add(ne);
            }

            while (i < intervals.Length)
            {
                nI.Add(intervals[i]);
                i++;
            }


            return nI.ToArray();
        }

        //public int[][] Insert(int[][] intervals, int[] newInterval)
        //{
        //    if (intervals.Length == 0)
        //        return new int[][] { newInterval };

        //    int i = -1;
        //    bool o = false;

        //    int[] ne = new int[] { newInterval[0], newInterval[1] };
        //    int[][] nI = new int[][] { };




        //    while(intervals.Length - 1 > i)
        //    {
        //        i++;

        //        int[] el = intervals[i];

        //        if (!o)
        //        {
        //            if (el[1] < newInterval[0])
        //            {
        //                nI = nI.Append(el).ToArray();
        //                continue;
        //            }

        //            if (el[0] <= ne[0] )
        //            {
        //                o = true;
        //                ne[0] = el[0];

        //                if (ne[1] <= el[1])
        //                {
        //                    ne[1] = el[1];
        //                    nI = nI.Append(ne).ToArray();
        //                    i++;
        //                    break;
        //                }
        //            }

        //            if (el[1] >= ne[1] && el[0] >= ne[1])
        //            {
        //                //ne[1] = el[1];
        //                nI = nI.Append(ne).ToArray();

        //                break;
        //            }





        //            continue;
        //        }


        //        if (el[1] < ne[1])
        //        {
        //            if (intervals.Length - 1 == i)
        //            {
        //                nI = nI.Append(ne).ToArray();
        //            }

        //            continue;
        //        }

        //        if (el[0] > ne[1])
        //        {
        //            nI = nI.Append(ne).ToArray();                    
        //            break;
        //        }


        //        if (el[0] <= ne[1] && ne[1] <= el[1])
        //        {
        //            ne[1] = el[1];
        //            nI = nI.Append(ne).ToArray();
        //            i++;
        //            break;
        //        }


        //    }

        //    if (!o)
        //    {
        //        nI = nI.Append(ne).ToArray();
        //        i++;
        //    }

        //    while (intervals.Length > i)
        //    {
        //        nI = nI.Append(intervals[i]).ToArray();
        //        i++;
        //    }



        //    return nI;
        //}

    }
}
