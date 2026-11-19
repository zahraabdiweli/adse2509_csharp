using System;

namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Program to demonstrate <see cref="ArrayTypeMismatchException"/> Exception
    /// </summary>
    public class ArrayTypeMismatchExceptionDemo
    {
        static void Main(string[] args)
        {
            // Declare and initialise an array of student names
            string[] studentNames = { "Chandni", "Tesfai", "Abigail" };
            // Declare and initialise an array of the student's admission/registration numbers
            uint[] admissionNums = { 1001, 1002, 1003 };
            // Declare and intialise an array of tuition fees
            double[] tuitionFee = { 5000.5, 4500.5, 55000.45 };
            // Declare and instantiate a float array of caution fee/money
            float[] cautionFee = new float[3];

            try
            {
                // Set the caution amount to the semester's tuition fee
                for (int n = 0; n < studentNames.Length; n++)
                    tuitionFee.CopyTo(cautionFee, n); // will cause an exception (double to float)
            }
            catch (ArrayTypeMismatchException atme)
            {
                Console.WriteLine($"What went wrong: {atme.Message}" +
                    $"\nError: {atme}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"The exception " +
                    $"{e.GetType().ToString().Replace("System.", "")} occurred.");
            }
        }
    }
}