using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Group2._11.ContainerWithMostWater
{
    internal class ContainerWithMostWater : IProblem

    {

        /*
            You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

            Find two lines that together with the x-axis form a container, such that the container contains the most water.

            Return the maximum amount of water a container can store.

            Notice that you may not slant the container.

 

            Example 1:


            Input: height = [1,8,6,2,5,4,8,3,7]
            Output: 49
            Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
            Example 2:

            Input: height = [1,1]
            Output: 1 
            
            Constraints:

            n == height.length
            2 <= n <= 105
            0 <= height[i] <= 104

         */


        public void Resolve()
        {

            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };



            Console.WriteLine("Container With Most Water");
            Console.WriteLine($"height: ");
            foreach (int i in height)
            {
                Console.Write($"{i}, ");
            }



            int result = MaxArea(height);

            Console.WriteLine($"=> Respuesta: {result}");




        }


        public int MaxArea(int[] height)
        {
            int a = 0;
            int temp;
            int l = height.Length;

            int i = 0;
            int f = l - 1;
                      

            while (true)
            {
                temp = (f - i) * ((height[i] > height[f]) ? height[f] : height[i]);

                if (temp > a)
                    a = temp;

                if (height[i] > height[f])
                    f--;
                else
                    i++;


                if (f <= i)
                    break;
            }




            return a;
        }


    }
}
