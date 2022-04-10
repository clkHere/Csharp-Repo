using System;
using System.Text;
using System.Threading;

namespace MadLib
{
    class MadLibProject
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a color: ");
            string uColor = Console.ReadLine();
            Console.Write("Please enter a plural noun: ");
            string uPluralNoun = Console.ReadLine();
            Console.Write("Please enter a celebrity name: ");
            string uCeleb = Console.ReadLine();

            Console.WriteLine("Roses are "+uColor+".");
            Console.WriteLine(uPluralNoun+" are blue.");
            Console.WriteLine("I love "+uCeleb+"."); 

            Console.ReadLine(); 
        }
    }
}