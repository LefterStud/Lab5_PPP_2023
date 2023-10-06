
using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// The BaseInform class contains general information about the school
    /// </summary>
    internal class BaseInform
    {
        private string _nameOfSchool;
        private string _location;
        private string _schoolType;
        private int _foundingYear;
        private string _phoneNumber;
        private const int MIN_YEAR = 1800;


        /// <summary>
        /// Creates a new instance of the BaseInform class with the given values.
        /// </summary>
        /// <param name="nameOfSchool">School name.</param>
        /// <param name="location">Location(city).</param>
        /// <param name="schoolType">Type of school.</param>
        /// <param name="foundingYear">Year of foundation.</param>
        /// <param name="phoneNumber">Phone number(format +XXXXXXXXXXXX).</param>
        public BaseInform(string nameOfSchool, string location, string schoolType, int foundingYear, string phoneNumber)
        {
            NameOfSchool = nameOfSchool;
            Location = location;
            PhoneNumber = phoneNumber;
            SchoolType = schoolType;
            FoundingYear = foundingYear;
        }

        /// <summary>
        /// Setter and getter for the _nameOfSchool field.
        /// School name.
        /// </summary>
        public string NameOfSchool
        {
            get => _nameOfSchool;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nameOfSchool = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(1);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _location field.
        /// Location(city).
        /// </summary>
        public string Location
        {
            get => _location;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _location = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
                }

                else
                {
                    Errors.SetErrorCode(2);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _phoneNumber field.
        /// Phone number in the format +ХХХХХХХХХХХХ.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if ((!string.IsNullOrEmpty(value)) && (Regex.IsMatch(value, @"^\+\d{12}$")))
                {
                    _phoneNumber = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(3);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _schoolType field.
        /// Type of school(Primary school, Secondary school, High school, gymnasium, lyceum, etc.).
        /// </summary>
        public string SchoolType
        {
            get => _schoolType;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _schoolType = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(4);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _foundingYear field.
        /// Foundation year(Not earlier than 1800).
        /// </summary>
        public int FoundingYear
        {
            get => _foundingYear;
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value >= MIN_YEAR && value <= currentYear)
                {
                    _foundingYear = value;
                }
                else
                {
                    Errors.SetErrorCode(5);
                }
            }
        }
    }

}

