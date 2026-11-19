using System;

namespace sess09_delegates_events_and_collections
{

    /// <summary>
    /// Defines a delegate that references methods performing
    /// arithmetic calculations on two integer values.
    /// </summary>
    /// <param name="num1">The first integer operand.</param>
    /// <param name="num2">The second integer operand.</param>
    /// <returns>
    /// An integer representing the result of the calculation.
    /// </returns>
    public delegate int Calculation(int num1, int num2);

    /// <summary>
    /// Demonstrates the use of delegates to reference and invoke 
    /// static methods that perform basic arithmetic operations, 
    /// including addition, multiplication and subtraction.
    /// </summary>
    public class SimpleDelegate
    {

        /// <summary>
        /// Add two integers and returns their sum.
        /// </summary>
        /// <param name="num1">The first integer value.</param>
        /// <param name="num2">The second integer value.</param>
        /// <returns>The sum of the two integer values.</returns>
        static int AddNums(int num1, int num2) { return num1 + num2; }

        /// <summary>
        /// Multiplies two integers and returns their product.
        /// </summary>
        /// <param name="num1">The first integer value.</param>
        /// <param name="num2">The second integer value.</param>
        /// <returns>The product of the two integer values.</returns>
        static int MultiplyNums(int num1, int num2) { return num1 * num2; }

        /// <summary>
        /// Subtracts two integers and returns their difference.
        /// </summary>
        /// <param name="num1">The first integer value.</param>
        /// <param name="num2">The second integer value.</param>
        /// <returns>The difference of the two integer values.</returns>
        static int SubtractNums(int num1, int num2) { return num1 - num2; }

        static void Main(string[] args)
        {
            // Declare and initialise values to be used in the program.
            int val1 = 5, val2 = 6;

            // Declare delegates for the class/static methods above
            Calculation addDelegate, prodDelegate, subDelegate;

            // Instantiate the above delegates objects
            addDelegate = new Calculation(AddNums);
            prodDelegate = new Calculation(MultiplyNums);
            subDelegate = new Calculation(SubtractNums);

            // Invoke the corresponding methods using their delegates
            Console.WriteLine($"Sum of {val1} + {val2} = {addDelegate(val1, val2)}");
            Console.WriteLine($"Product of {val1} x {val2} = {prodDelegate(val1, val2)}");
            Console.WriteLine($"Difference of {val1} - {val2} = {subDelegate(val1, val2)}");
        }


    }
}