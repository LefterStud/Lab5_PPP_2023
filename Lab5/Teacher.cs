
using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// Teacher class. Contains the properties of the teacher, 
    /// and also inherits the properties of the School class
    /// </summary>
    public class Teacher : School
    {
        private string _name;
        private string _specialization;
        private int _seniority;
        private int _classroomNumber;

        /// <summary>
        /// Creates a new instance of the Teacher class and and inherits the properties of School
        /// </summary>
        /// <param name="nameOfSchool">School name.</param>
        /// <param name="location">Location(city).</param>
        /// <param name="schoolType">Type of school.</param>
        /// <param name="foundingYear">Year of foundation.</param>
        /// <param name="phoneNumber">Phone number(format +XXXXXXXXXXXX).</param>
        /// <param name="name">Name of teacher.</param>
        /// <param name="specialization">Specialization of teacher.</param>
        /// <param name="seniority">Seniority of teacher.</param>
        /// <param name="classroomNumber">Which classroom is it in?</param>
        public Teacher(string nameOfSchool, string location, string schoolType, int foundingYear, string phoneNumber, string name, string specialization, int seniority, int classroomNumber) : base(nameOfSchool, location, schoolType, foundingYear, phoneNumber)
        {
            Name = name;
            Specialization = specialization;
            Seniority = seniority;
            ClassroomNumber = classroomNumber;
        }

       

        /// <summary>
        /// Setter and getter for the _name field.
        /// Teacher`s name.
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
        /// Setter and getter for the _specialization field.
        /// Teacher's specialization.
        /// </summary>
        public string Specialization
        {
            get => _specialization;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _specialization = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(8);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _seniority field.
        /// Teacher`s seniority.
        /// </summary>
        public int Seniority
        {
            get => _seniority;
            set
            {
                if (value >= 0)
                {
                    _seniority = value;
                }
                else
                {
                    Errors.SetErrorCode(9);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _classroomNumber field.
        /// Number of teacher`s classroom.
        /// </summary>
        public int ClassroomNumber
        {
            get => _classroomNumber;
            set
            {
                string classroomStr = value.ToString();
                if (Regex.IsMatch(classroomStr, @"^1\d{2}$"))
                {
                    _classroomNumber = value;
                }
                else
                {
                    Errors.SetErrorCode(10);
                }
                
            }
        }


        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() : $"Teacher:\nName: {Name};\nSpecialization: " +
                $"{Specialization};\nSeniority: {Seniority};\nClassroom number: {ClassroomNumber}\n{base.ToString()}";
        }
    }
}
