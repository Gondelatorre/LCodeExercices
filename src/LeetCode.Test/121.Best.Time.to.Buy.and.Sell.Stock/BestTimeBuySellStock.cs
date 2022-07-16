using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class BestTimeBuySellStock : IProblem
    {

        /*    121
         
        url: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
         
        You are given an array prices where prices[i] is the price of a given stock on the ith day.

        You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 

        Example 1:

        Input: prices = [7,1,5,3,6,4]
        Output: 5
        Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        Example 2:

        Input: prices = [7,6,4,3,1]
        Output: 0
        Explanation: In this case, no transactions are done and the max profit = 0.
 

        Constraints:

        1 <= prices.length <= 10 x5
        0 <= prices[i] <= 10 x4

         
         */

        internal static BestTimeBuySellStock Create()
        {
            return new BestTimeBuySellStock();
        }


        public void Resolve()
        {
            //int[] prices = new int[] { 7, 1, 4, 3, 6, 4 };
            int[] prices = new int[] { 3, 2, 6, 5, 0, 3 };

            Console.Write($"Precios: ");
            foreach (int i in prices)
            {
                Console.Write($"{i}, ");
            }

            int result = MaxProfit(prices);

            Console.WriteLine($"=> Respuesta:  {result}");

        }


        public int MaxProfit(int[] prices)
        {
            int profit = 0;

            int min = prices[0];
            int max = min;

            for (int i = 1; i < prices.Length; i++)
            {
                int p = prices[i];

                if (p < min)
                {
                    min = p;
                    max = p;
                    continue;
                }

                if (p > max)
                {
                    max = p;
                    profit = (profit > (max - min)) ? profit : (max - min);
                    continue;
                }




            }

            return profit;



        }

    }
}
