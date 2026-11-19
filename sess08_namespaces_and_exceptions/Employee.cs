using sess07_properties_records_indexers;
using System;

namespace sess08_namespaces_and_exceptions
{
    /// <summary>
    /// Represents an instance of the <see cref="Employee"/> class with details derived from the <see cref="SimplerPerson"/> class and the employee's ID.
    /// </summary>
    public class Employee : SimplerPerson
    {
        //=========================================================
        // EMPLOYEE PROPERTIES
        //=========================================================

        /// <summary>
        /// Gets or sets the employee's unique identifier
        /// </summary>
        public uint EmpID { get; set; }

        //=========================================================
        // OVERIDDEN METHOD(S)
        //=========================================================
        /// <summary>
        /// Returns a formatted string representation of the employee's  details.
        /// </summary>
        /// <returns>
        /// A human-readable representation of the employee's ID, name, birthdate, gender and nationality.
        /// </returns>
        public override string ToString()
        {
            return $"Employee's Details" +
                $"\n" + new string('-', 55) +
                $"\nEmployee ID: {this.EmpID}" +
                $"\nNames: {this.Name}" +
                $"\nDate of birth: {this.BirthDate}" +
                $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
                $"\nNationality: {this.Nationality}";

        }
    }

    namespace Salary
    {
        class SalaryDetails
        {
            public double EmployeeSalary { get; set; }

            public override string ToString()
            {
                return $"\nSalary Amount: Kes. {this.EmployeeSalary:n2}" +
                    $"\n" + new string('-', 55);
            }
        }
    }
}