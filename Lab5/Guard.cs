
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// Guard class. Contains the properties of the guard, 
    /// and also imitates the properties of the School class
    /// </summary>
    public class Guard : School
    {
        private string _name;
        private string _shift;
        private int _shiftDuration;
        private string _securityService;
        private const double MIN_DURATION = 1;
        private const double MAX_DURATION = 12;

        /// <summary>
        /// Creates a new instance of the Guard class and and inherits the properties of School
        /// </summary>
        /// <param name="nameOfSchool">School name.</param>
        /// <param name="location">Location(city).</param>
        /// <param name="schoolType">Type of school.</param>
        /// <param name="foundingYear">Year of foundation.</param>
        /// <param name="phoneNumber">Phone number(format +XXXXXXXXXXXX).</param>
        /// <param name="name">Name of guard.</param>
        /// <param name="shift">Shift of guard.</param>
        /// <param name="shiftDuration">Shift duration.</param>
        /// <param name="securityService">Security service.</param>
        public Guard(string nameOfSchool, string location, string schoolType, int foundingYear, string phoneNumber, string name, string shift, int shiftDuration, string securityService) : base(nameOfSchool, location, schoolType, foundingYear, phoneNumber)
        {
            Name = name;
            Shift = shift;
            ShiftDuration = shiftDuration;
            SecurityService = securityService;
        }

        /// <summary>
        /// Setter and getter for the _name field.
        /// Guard`s name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, @"^[A-Za-z ]+$"))
                {
                    _name = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(7);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _shift field.
        /// Guard`s shift.
        /// </summary>
        public string Shift
        {
            get => _shift;
            set
            {
                if ((value.ToLower() == "day" || value.ToLower() == "night"))
                {
                    _shift = value;
                }
                else
                {
                    Errors.SetErrorCode(14);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _shiftDuration field.
        /// Guard`s shift duration.
        /// </summary>
        public int ShiftDuration
        {
            get => _shiftDuration;
            set
            {
                if (value >= MIN_DURATION && value <= MAX_DURATION)
                {
                    _shiftDuration = value;
                }
                else
                {
                    Errors.SetErrorCode(15);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _securityService field.
        /// Guard`s security service.
        /// </summary>
        public string SecurityService
        {
            get { return _securityService; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _securityService = value;
                }
                else
                {
                    Errors.SetErrorCode(16);
                }
            }
        }

        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() : $"Guard:\nName: {Name};\nShift: {Shift};" +
                $"\nShift duration: {ShiftDuration};\nSecurity service: {SecurityService}\n{base.ToString()}";
        }
    }
}
