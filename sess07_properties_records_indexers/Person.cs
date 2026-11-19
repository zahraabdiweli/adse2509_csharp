
using System.Reflection;
using System.Runtime.InteropServices;

namespace sess07_properties_records_indexers
{
    public record  Person(string  Name, byte Age, string Email)

    {
        //------------------------------------------------
        // OVERRIDDEN METHODS (S)
        //-----------------------------------------------

        /// <summary>
        /// Returns a formatted string representation of the person's details.
        /// </summary>
        /// <summary>
        /// overrides the default <see cref="ToString"/> method to give a custom representation of the person's details.
        /// </summary>
        /// <returns>A readable representation of the person's name, birth date, gender, and nationality.</returns>
        public override string ToString()
        {
            return "Person's Details" +
                "\n" + new string('-', 55) +
                $"\nNames: {this.name}" +
                $"\nAge: {this.Age}" +
                $"\nGender: {(Gender == 'M' || Gender == 'm' ? "Male" : "Female")}" +
                $"\nEmail: {this.Email}" +
                "\n" + new string('-', 55);
        }
}
