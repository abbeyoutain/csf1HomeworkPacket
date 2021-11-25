using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csf1Homework
{
    class FruitLoops
    {
        static void Main(string[] args)
        {
            //Fruit Loops 1

            Console.WriteLine("Fruit Loops");

            string[] fruit = { "apple",
                               "apricot",
                               "peach",
                               "plum",
                               "pear",
                               "pomegranate" };

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }//end for

            //Fruit Loops 2

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.Write(fruit[i]);
                for (int nbrLoops = 0; nbrLoops < i; nbrLoops++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }//end for

        }//end SVM
    }//end class
}//end namespace
