using System;

namespace sess07_properties_records_indexers
{
    /// <summary>
    /// Represents a Person object with details such as name, birth date, gender, and nationality.
    /// </summary>
    public class SimplerPerson
    {
        // PERSON PROPERTIES

        /// <summary>
        /// Gets or sets the person's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the person's date of birth.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the person's gender using 'M' or 'm' for male and 'F' or 'f' for female.
        /// </summary>
        public char Gender { get; set; }

        /// <summary>
        /// Gets or sets the person's nationality.
        /// </summary>
        public string Nationality { get; set; }

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplerPerson"/> class with default values.
        /// </summary>
        public SimplerPerson()
        {
            Name = string.Empty;
            BirthDate = DateTime.MinValue;
            Gender = 'M';
            Nationality = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimplerPerson"/> class with the specified values.
        /// </summary>
        /// <param name="name">The person's name.</param>
        /// <param name="birthDate">The person's birth date.</param>
        /// <param name="gender">The person's gender.</param>
        /// <param name="nationality">The person's nationality.</param>
        public SimplerPerson(string name, DateTime birthDate, char gender, string nationality)
        {
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            Nationality = nationality;
        }

        // Overridden methods

        /// <summary>
        /// Returns a formatted string representation of the person's details.
        /// </summary>
        /// <returns>A readable representation of the person's name, birth date, gender, and nationality.</returns>
        public override string ToString()
        {
            return "Person's Details" +
                "\n" + new string('-', 55) +
                $"\nNames: {Name}" +
                $"\nDate of birth: {BirthDate}" +
                $"\nGender: {(Gender == 'M' || Gender == 'm' ? "Male" : "Female")}" +
                $"\nNationality: {Nationality}" +
                "\n" + new string('-', 55);
        }
    }
}