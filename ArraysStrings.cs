using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataStructsAlgorithms_Arrays_Strings
{
    /* 
     Data structure is a way of organizing and storing data. 
    --  A 'Tree' for example is a hierarchy structure. 
    --  A 'Sequence' is a descending structure
    --  A 'Queue' is a FIFO structure
    --  There are over 500 data strcutures. 
    --  By taking an 'Abstract' approach to data structures...
        ...you can make it easier. 
    ->     EX : Arrays - 1D, 2D, Multi-D - ARE JUST ARRAYS! 
    ->     EX : Linked Lists - Single, Double, Multiple - ARE JUST LINKED LISTS!
    */

    class ArraysStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
        }
        // O(n^2) -> Big 'O' notation is simply the algorithms experienced
        // performance

        // O((1) - Neutral
        void Function1(List<string> data) //Performance takes the same
                                          //amount of time.
        {
            string str = data[0]; 
        }
        

        // O(n) -- Linear
        void Function2(List<string> data)// Time will increase by record 
        {
            foreach(string str in data)
            {
                if (str == "shiv")
                {
                    return;
                }
            }
        }

        // O(n^2) -- Quadratic
        void Function3(List<string> data)// Time will increase by record 
        {
            foreach (string str in data)
            {
                if (str == "shiv")
                {
                    return;
                }
            }
        }

    }
}
