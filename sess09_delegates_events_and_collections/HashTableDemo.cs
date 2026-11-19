using sess07_properties_records_indexers;
using System;
using System.Collections;

namespace sess09_delegates_events_and_collections
{
    /// <summary>
    /// Program to demonstrate the <see cref="HashTable"/> class.
    /// </summary>
    public class HashTableDemo
    {
        static void Main(string[] args)
        {
            uint n = 0;
            Hashtable bookTable = new Hashtable();
            bookTable.Add(101, new Book(578, "C# How to Program", "Deitel & Deitel", 7100.0f));
            bookTable.Add(102, new Book(579, "C# Notes for Professionals", "Et al", 0.0f));
            bookTable.Add(103, new Book(580, "Java the Complete Reference", "Oracle Inc.", 11710.0f));
            bookTable.Add(104, new Book(581, "Web Scraping with Python", "Ryan Mitchelle", 7100.0f));
            bookTable.Add(105, new Book(582, "Fundamentals of Web Development", "Randy & Ricardo", 9700.0f));
            bookTable.Add(106, new Book(583, "Clean Code", "Robert C. Martin", 4500.0f));
            bookTable.Add(107, new Book(584, "The Pragmatic Programmer", "David Thomas & Andrew Hunt", 5200.0f));
            bookTable.Add(108, new Book(585, "Head First Java", "Kathy Sierra & Bert Bates", 3800.0f));

            // Display the number of books in the books hashtable
            Console.WriteLine($"The number of books in the dictionary is: {bookTable.Count}");

            // Get a collection of keys from the books hashtable
            ICollection bookTableKeys = bookTable.Keys;
            // Display the bookTable keys
            Console.WriteLine("The keys in the Hashtable are: " +
                "\n" + new string('-', 55));
            foreach (var key in bookTableKeys)
                Console.WriteLine($"Key {++n:00}: {key}");

            // Remove the details for key 106
            if (bookTable.Contains(106))
            {
                bookTable.Remove(106);
                Console.WriteLine("Removed details for record 106");
            }
            else
                Console.WriteLine("Sorry, record 106 doesn't exist.\nKindly confirm and try again.");

            // Display the hashtable contents afte removing record 106
            Console.WriteLine("\nThe contents of the books hashtable after removing key 106 are:\n");
            DisplayHashtableContents(bookTable);

            // Display some properties of the books hashtable
            Console.WriteLine($"The books hashtable is read-only: {bookTable.IsReadOnly}");
            Console.WriteLine($"The books hashtable is fixed size: {bookTable.IsFixedSize}");

        }

        private static void DisplayHashtableContents(Hashtable bookTable)
        {
            IDictionaryEnumerator bookEnumerator = bookTable.GetEnumerator();
            while (bookEnumerator.MoveNext())
                Console.WriteLine($"Key: {bookEnumerator.Key} \nValue: {bookEnumerator.Value.ToString()}");
        }
    }
}