using System;
using System.Collections;

namespace sess09_delegates_events_and_collections
{
    /// <summary>
    /// Program to demonstrate the <see cref="ArrayList"/> class and some of its methods
    /// </summary>
    public class ArrayListDemo
    {
        static void Main(string[] args)
        {
            // Declare and instantiate an ArrayList object/instance
            ArrayList fruitList = new ArrayList();

            // Display the initial capacity of the fruitList object
            Console.WriteLine($"The initial capacity of the 'fruitList' is: {fruitList.Capacity}");

            // Add fruits to the fruitList
            fruitList.Add("Apple");
            fruitList.Add("Peach");
            fruitList.Add("Banana");
            fruitList.Add("Orange");
            fruitList.Add("Mango");
            fruitList.Add("Pineapple");
            fruitList.Add("Watermelon");
            fruitList.Add("Strawberry");
            fruitList.Add("Dragon Fruit");
            fruitList.Add("Plums");
            fruitList.Add("Passion");
            fruitList.Add("Pawpaw");
            fruitList.Add("Cherry");
            fruitList.Add("Kiwi");
            fruitList.Add("Blackberry");
            fruitList.Add("Avocado");
            fruitList.Add("Guava");
            fruitList.Add("Beetroot");
            fruitList.Add("Durian");
            fruitList.Add("Grapes");

            // Display the original list of fruits
            Console.WriteLine($"\nThe original fruitList has {fruitList.Count} fruits, and" +
                $" they are listed below: ");
            foreach (string fruit in fruitList)
                Console.WriteLine(fruit);

            // Insert a fruit before 'mango;
            fruitList.Insert(4, "Lemon");
            // Replace 'orange' with 'kiwi fruit'
            fruitList[3] = "Kiwi fruit";

            // Display the modified and unsorted list of fruits
            Console.WriteLine($"\nThe modified fruitList has {fruitList.Count} fruits, and" +
                $" they are listed below: ");
            for (uint n = 0; n < fruitList.Count; n++)
                Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");

            // Sort the 'fruitList' in reverse lexicographical (descending) order
            fruitList.Sort(); // Sort fruitList in ascending order
            fruitList.Reverse(); // Reverse the above sort (effectively sorting them in descending order)
            Console.WriteLine($"\nThe fruitList in reverse lexicographical order is:");
            for (uint n = 0; n < fruitList.Count; n++)
                Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");

        }
    }
}