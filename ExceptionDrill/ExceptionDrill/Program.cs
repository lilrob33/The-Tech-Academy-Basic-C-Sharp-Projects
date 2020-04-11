using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            // set up array
            int[] numArray = { 10, 200, 230, 78, 120 };
            Console.WriteLine("Please pick a number to divide into the numbers in the list.");

            try 
            {
            int num1 = Convert.ToInt32(Console.ReadLine());
            foreach (int items in numArray) // foreach to iterate through array
            {    
                    Console.WriteLine(items + " divided by " + num1 + " = " + items / num1);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type numbers only: {0}", ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Unable to divide by zero: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
      
        finally
        {
            Console.WriteLine("\nProgram has emerged from the try/catch block and execution to be continued...");
            Console.ReadLine();
        }
        }
    }
