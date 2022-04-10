using System;
using System.Text;
using System.Threading;

namespace TwoDarray
{
    class TwoDArrayPractice
    {
        static void Main(string[] args)
        {
            //2D array [,] designator
            int[,] numberGrid = {
            {1,2 },
            {3,4},
            {5,6},            
            };

            Console.WriteLine(numberGrid[1,1]+"-> Answer should return FOUR");
            Console.WriteLine(numberGrid[2, 0] + "-> Answer should return FIVE");
            Console.WriteLine(numberGrid[0, 0] + "-> Answer should return ONE");
            Console.WriteLine(numberGrid[1, 0] + "-> Answer should return THREE");
            Console.WriteLine(numberGrid[2, 1] + "-> Answer should return SIX");

            /* 
            --2D Arrays read from left-to-right AND starts at index 0
            **IMPORTANT**
            --Follows a "[ROW,COLUMN] Pattern 

            EXAMPLE: 

            int[,] numberGrid = { {1,2}, {3,4}, {5,6} }; 

                     COL0  COL1    
            ===================   
            ROW 0|     1     2    
            ROW 1|     3     4    
            ROW 2|     5     6    
            ===================   

            [0,0] -> Returns 1
            [0,1] -> Returns 2
            [1,0] -> Returns 3
            [1,1] -> Returns 4
            [2,0] -> Returns 5
            [2,1] -> Returns 6

            */

            Console.ReadLine();
        }
    }
}