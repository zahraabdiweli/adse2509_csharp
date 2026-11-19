using System;

namespace sess09_delegates_events_and_collections
{
    /// <summary>
    /// Defines the signature of an even handler that receives a string value.
    /// </summary>
    /// <param name="value">The string value supplied to the event handler</param>
    public delegate void MyEventHandler(string value);

    /// <summary>
    /// Demonstrates the use of delegates and events to notify subscribers whenever
    /// a user enters a new string through the console
    /// </summary>
    /// <remarks>
    /// The application continues prompting the user until they enter "exit",
    /// regardless of the letter casing used.
    /// </remarks>
    public class EventDelegate
    {
        static void Main(string[] args)
        {
            // Create an instance of the event publisher.
            EventPublisher eventPub = new EventPublisher();

            // Subscribe to the ValueChanged event
            eventPub.ValueChanged += UserStringChanged;

            try
            {
                string? userString;

                do
                {
                    // Request/prompt the user to enter a string
                    Console.WriteLine("Please enter some text or type 'exit' to end the application.");

                    userString = Console.ReadLine();

                    // Handle null input (for example, when the input stream is closed).
                    if (userString is null)
                    {
                        Console.WriteLine("No input received. Goodbye!");
                        break;
                    }

                    // Exist the application if the user enters 'exit'
                    if (!string.Equals(userString, "exit", StringComparison.OrdinalIgnoreCase))
                    {
                        eventPub.Value = userString;
                    }
                }
                while (!string.Equals(userString, "exit", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Goodbye!");
            }
            finally
            {
                // Unsubscribe from the event when it's no longer required.
                eventPub.ValueChanged -= UserStringChanged;
            }
        }

        /// <summary>
        /// Handles the ValueChanged event raised by the EventPublisher.
        /// Displays the new string entered by the user in the console.
        /// </summary>
        /// <param name="newInput">
        /// The new string value entered by the user.
        /// </param>
        private static void UserStringChanged(string newInput)
        {
            Console.WriteLine($"The user has typed: \"{newInput}\"\n");
        }

    }

    internal class EventPublisher
    {
        /// <summary>
        /// Stores the current string value maintained by the publisher
        /// </summary>
        private string? _val;

        /// <summary>
        /// Occurs when the <see cref="Value"/> property is assigned a new value.
        /// </summary>
        /// <remarks>
        /// Subscribers receive the updated string through the event handler
        /// </remarks>
        public event MyEventHandler? ValueChanged;

        public string? Value
        {
            get => _val;

            set
            {
                // Update the stored string value
                _val = value;

                // Notify subscribers that the value has changed
                OnValueChanged(_val);
            }
        }

        /// <summary>
        /// Raises the <see cref="ValueChanged"/> event.
        /// </summary>
        /// <param name="value">
        /// The updated string value to pass to the registered event handlers
        /// </param>
        protected virtual void OnValueChanged(string? value)
        {
            ValueChanged?.Invoke(value!);
        }
    }
}