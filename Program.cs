/*
Programmer: Alaeldeen Alkenani
Date: 9/27/2020
Discription: This console application demonstrates the use of 
             arrays by executing an array that is the size 25 elements.
*/

using System;

namespace Tech_Project_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manually Populated Data");

            // Utilize try and catch to prevent the application from crashing
            try
            {
                // Manually Populated Array
                int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                
                // Show array values
                foreach (int i in array)
                {
                    Console.WriteLine("Element Value = " + i);

                }    
                
                Console.WriteLine("Press any key to exit program...");

            } catch
            {
                Console.ReadKey(true);

            } // end of catch

        } // end of main

    } // end of program

} // end of namespace
