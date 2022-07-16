﻿// See https://aka.ms/new-console-template for more information
using LeetCode.Test;
using LeetCode.Test._556.Next.Greater.Element.III;

// Indice de problemas
#region Indice de problemas
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


// ** Especificar cual problema resolver **
var p = Problems.Group1.GameOfLife;



var problemFactory = new ProblemFactory();
IProblem problem = problemFactory.Resolve(p.ToString());


problem.Resolve();

Console.ReadKey();