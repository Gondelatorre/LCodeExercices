using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class GameOfLife : IProblem
    {
        /*
            289. Game of Life

            According to Wikipedia's article: "The Game of Life, also known simply as Life, 
            is a cellular automaton devised by the British mathematician John Horton Conway in 1970."

            The board is made up of an m x n grid of cells, where each cell has an initial state: 
            live (represented by a 1) or dead (represented by a 0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) 
            using the following four rules (taken from the above Wikipedia article):

            - Any live cell with fewer than two live neighbors dies as if caused by under-population.
            - Any live cell with two or three live neighbors lives on to the next generation.
            - Any live cell with more than three live neighbors dies, as if by over-population.
            - Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
            
            The next state is created by applying the above rules simultaneously to every cell in the current state, 
            where births and deaths occur simultaneously. Given the current state of the m x n grid board, return the next state. 
          

            Input: board = [[0,1,0],[0,0,1],[1,1,1],[0,0,0]]
            Output: [[0,0,0],[1,0,1],[0,1,1],[0,1,0]]
      
        */


        internal static GameOfLife Create()
        {
            return new GameOfLife();
        }


        public void Resolve()
        {
            const int m = 4;
            const int n = 3;

            int[][] board = new int[m][];

            board[0] = new int[n] { 0, 1, 0 };
            board[1] = new int[n] { 0, 0, 1 };
            board[2] = new int[n] { 1, 1, 1 };
            board[3] = new int[n] { 0, 0, 0 };


            Console.WriteLine($"Board: ");

            foreach (var b in board)
            {
                Console.WriteLine(string.Join(", ", b));
            }


            GameOfLifeResolve(board);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"=> Respuesta:");

            foreach (var b in board)
            {
                Console.WriteLine(string.Join(", ", b));
            }
        }


        public void GameOfLifeResolve(int[][] board)
        {
            int m = board.Length;
            int n = board[0].Length;

            int[][] result = new int[m][];

            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
            }

            

            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for(int j = 0; j < n; j++)
                {
                    result[i][j] = DefAliveOrDeath(board[i][j], CalcNeighbors(board, i, j));
                }

            }


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i][j] = result[i][j];
                }
            }


        }


        public int CalcNeighbors(int[][] board, int ipos, int jpos)
        {
            int n = 0;

            int li = board.Length;
            int lj = board[0].Length;

            for (int i = ipos - 1; i <= ipos+1; i++)
            {
                if (i < 0 || i >= li) continue;

                for (int j = jpos - 1; j <= jpos+1; j++)
                {
                    if (j < 0 || j >= lj || (i == ipos && j == jpos)) continue;
                    

                    int alive = board[i][j];
                    n = n + (alive == 1 ? 1: 0);
                }
            }

            return n;

        }


        public int DefAliveOrDeath(int isAlive, int neighbors)
        {
            if (isAlive == 1)
            {
                if (neighbors < 2)
                    return 0;
               
                if (neighbors > 3)
                    return 0;

                return 1;
            } else
            {
                if (neighbors == 3)
                    return 1;

                return 0;
            }


        }


    }
}
