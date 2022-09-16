// See https://aka.ms/new-console-template for more information
using LeetCode.Test;
using LeetCode.Test._556.Next.Greater.Element.III;

// Indice de problemas
#region Indice de problemas

#region Group 1
/*
    Group 1 
        217.    ContainsDuplicate,
        1.      TwoSum,
        121.    BestTimeBuySellStock,
        238.    ProductOfArrayExceptSelf,
        53.     MaximumSubarray,
        152.    MaximumProductSubarray,
        289.    GameOfLife

*/
#endregion

#region Group 2
    /* 
       Group 2
        153.    Min Rotate Sort Array
        33.     Search in Rotated Sorted Array
        15.     Three Sum
        1.      Container With Most Water
    */

#endregion


#endregion




// ** Especificar cual problema resolver **
var p = Problems.Group2.ContainerWithMostWater;



var problemFactory = new ProblemFactory();
IProblem problem = problemFactory.Resolve(p.ToString());


problem.Resolve();

Console.ReadKey();