

using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// Ісрщщдсршдв class. Contains the properties of the ісрщщдсршдв, 
    /// and also imitates the properties of the School class
    /// </summary>
    public class Schoolchild : School
    {
        private string _name;
        private double _averageMark;
        private int _grade;
        private int _numberOfSubjects;
        private const double MAX_MARK = 12;
        private const double MIN_CLASS = 1;
        private const double MAX_CLASS = 12;
        private const double MAX_SUBJECTS = 30;

        /// <summary>
        /// Creates a new instance of the Schoolchild class and and inherits the properties of School
        /// </summary>
        /// <param name="nameOfSchool">School name.</param>
        /// <param name="location">Location(city).</param>
        /// <param name="schoolType">Type of school.</param>
        /// <param name="foundingYear">Year of foundation.</param>
        /// <param name="phoneNumber">Phone number(format +XXXXXXXXXXXX).</param>
        /// <param name="name">Name of Schoolchild.</param>
        /// <param name="averageMark">Average mark.</param>
        /// <param name="grade">Grade of schoolchild.</param>
        /// <param name="numberOfSubjects">Number of subjects.</param>
        public Schoolchild(string nameOfSchool, string location, string schoolType, int foundingYear, string phoneNumber, string name, double averageMark, int grade, int numberOfSubjects) : base(nameOfSchool, location, schoolType, foundingYear, phoneNumber)
        {
            Name = name;
            AverageMark = averageMark;
            Grade = grade;
            NumberOfSubjects = numberOfSubjects;
        }

        /// <summary>
        /// Setter and getter for the _name field.
        /// Schoolchild`s name.
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
        /// Setter and getter for the _averageMark field.
        /// Schoolchild`s average mark.
        /// </summary>
        public double AverageMark
        {
            get => _averageMark;
            set
            {
                if (value > 0 && value <= MAX_MARK)
                {
                    _averageMark = value;
                }
                else
                {
                    Errors.SetErrorCode(11);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _grade field.
        /// Schoolchild`s grade. 
        /// </summary>
        public int Grade
        {
            get => _grade;
            set
            {
                if (value >= MIN_CLASS && value <= MAX_CLASS)
                {
                    _grade = value;
                }
                else
                {
                    Errors.SetErrorCode(12);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _numberOfSubjects field.
        /// Schoolchild`s number of subjects. 
        /// </summary>
        public int NumberOfSubjects
        {
            get => _numberOfSubjects;
            set
            {
                if (value > 0 && value <= MAX_SUBJECTS)
                {
                    _numberOfSubjects = value;
                }
                else
                {
                    Errors.SetErrorCode(13);
                }
            }
        }

        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() : $"Schoolchild:\nName: {Name};\nAverage Mark: " +
                $"{AverageMark};\nGrane: {Grade};\nNumber of subjects: {NumberOfSubjects}\n{base.ToString()}";
        }
    }
}
