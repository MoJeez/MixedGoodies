using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Collections
{
    class Arrays
    {
        private void main()
        {
            //Et Array er en collection af variabler.
            //Et array kan defineres på forskellige måder


            //Dette array har 10 pladser.
            int[] IntegerArray = new int[10];
            //dvs. for at tilgå variablerne kan du skrive:
            Console.WriteLine(IntegerArray[0]);
            Console.WriteLine(IntegerArray[1]);
            Console.WriteLine(IntegerArray[2]);
            Console.WriteLine(IntegerArray[3]);
            Console.WriteLine(IntegerArray[4]);
            Console.WriteLine(IntegerArray[5]);
            Console.WriteLine(IntegerArray[6]);
            Console.WriteLine(IntegerArray[7]);
            Console.WriteLine(IntegerArray[8]);
            Console.WriteLine(IntegerArray[9]);
            //Læg mærke til at den største er 9.
            
            //du kan definere variablerne i en int ved at:
            int[] IntArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Eller
            IntArray[5] = 1234;
            //Nu er intArray Plads 5 givet værdien 1234

            //MultiDimensional Arrays
            int[,] MultiIntegerArray = new int[2,5];
            //Den her ser nogenlunde sådan her ud
            int[,] MyMultiIntegerArray = new int[,] 
            {
                {1,2,3,4,5},
                {1,2,3,4,5}
            };
            //Dette kan tilgåes således:
            Console.WriteLine(MyMultiIntegerArray[0, 0]);
            Console.WriteLine(MyMultiIntegerArray[0, 1]);
            Console.WriteLine(MyMultiIntegerArray[0, 2]);
            Console.WriteLine(MyMultiIntegerArray[0, 3]);
            Console.WriteLine(MyMultiIntegerArray[0, 4]);

            Console.WriteLine(MyMultiIntegerArray[1, 0]);
            Console.WriteLine(MyMultiIntegerArray[1, 1]);
            Console.WriteLine(MyMultiIntegerArray[1, 2]);
            Console.WriteLine(MyMultiIntegerArray[1, 3]);
            Console.WriteLine(MyMultiIntegerArray[1, 4]);
        }
    }
}