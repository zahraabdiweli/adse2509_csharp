using System;

namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Demonstrates how the DivideByZeroException class
    /// handles attempts to divide an integer by zero.
    /// </summary>
    public class DivideByZeroExceptionDemo
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args">
        /// Command-line arguments supplied to the application.
        /// </param>
        private static void Main(string[] args)
        {
            // Declare two integer variables.
            int numerator = 100;
            int denominator = 0;

            try
            {
                // Attempt to divide the numerator by zero.
                // This operation causes a DivideByZeroException.
                int result = numerator / denominator;

                // Display the result if the operation succeeds.
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                // Handle the exception when division by zero occurs.
                Console.WriteLine("Exception caught!");
                Console.WriteLine("Exception type: " +
                                  ex.GetType().Name);

                // Display the exception message.
                Console.WriteLine("Error message: " + ex.Message);
            }
            finally
            {
                // This block executes whether an exception occurs or not.
                Console.WriteLine("The division operation has finished.");
            }

            // Keep the console window open until the user presses a key.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}