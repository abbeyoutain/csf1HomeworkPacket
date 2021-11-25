using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csf1Homework
{
    class MadLibs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words below for a dragon-themed mad lib!");
            Console.ReadLine();

            Console.WriteLine("Color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Superlative ending in -est: ");
            string superlative = Console.ReadLine();

            Console.WriteLine("Adjective: ");
            string adjective = Console.ReadLine();

            Console.WriteLine("Body part (pural): ");
            string bodyPartPlural = Console.ReadLine();

            Console.WriteLine("Body part: ");
            string bodyPart = Console.ReadLine();

            Console.WriteLine("Noun: ");
            string noun = Console.ReadLine();

            Console.WriteLine("Animal (plural): ");
            string animalPlural = Console.ReadLine();

            Console.WriteLine("Adjective: ");
            string adjective1 = Console.ReadLine();

            Console.WriteLine("Adjective: ");
            string adjective2 = Console.ReadLine();

            Console.WriteLine("Adjective: ");
            string adjective3 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"The {color} dragon is the {superlative} dragon of all. It has {adjective} {bodyPartPlural}, and a {bodyPart} shaped like a {noun}. It loves to eat {animalPlural}, although it will feast on nearly anything. It is {adjective1} and {adjective2}. You must be {adjective3} around it, or you may end up as it`s meal!");

        }//svm
    }//class
}//namespace
