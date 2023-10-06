
namespace Lab5
{
    /// <summary>
    /// Basic class-aggregate, which consists of general information about the school.
    /// Also contains a collection of people related to the school.
    /// </summary>
    public class School
    {
        private BaseInform _baseInform;
        private School[] _schoolCommunity;

        /// <summary>
        /// Creates a new instance of the School class that aggregates an instance of the BaseInform class
        /// </summary>
        /// <param name="nameOfSchool">School name.</param>
        /// <param name="location">Location(city).</param>
        /// <param name="schoolType">Type of school.</param>
        /// <param name="foundingYear">Year of foundation.</param>
        /// <param name="phoneNumber">Phone number(format +XXXXXXXXXXXX).</param>
        public School(string nameOfSchool, string location, string schoolType, int foundingYear, string phoneNumber)
        {
            _baseInform = new BaseInform(nameOfSchool, location, schoolType, foundingYear, phoneNumber);
        }

        /// <summary>
        /// Creates an array of the school class that will contain people associated with the school.
        /// </summary>
        public School()
        {
            _schoolCommunity = new School[0];
        }


        /// <summary>
        /// Adds an object to the array.
        /// </summary>
        /// <param name="school">An instance of the School class or those derived from School</param>
        public void AddMember(School school)
        {
            Array.Resize(ref _schoolCommunity, _schoolCommunity.Length + 1);
            _schoolCommunity[_schoolCommunity.Length - 1] = school;
        }

        /// <summary>
        /// Delete an object from the array.
        /// </summary>
        /// <param name="index">The index of the element to be deleteed</param>
        public void DeleteMember(int index)
        {
            if (index >= 0 && index < _schoolCommunity.Length)
            {
                Array.Copy(_schoolCommunity, index + 1, _schoolCommunity, index, _schoolCommunity.Length - index - 1);
                Array.Resize(ref _schoolCommunity, _schoolCommunity.Length - 1);
            }
            else
            {
                Errors.SetErrorCode(6);
            }
        }

        /// <summary>
        /// Edit element of array
        /// </summary>
        /// <param name="index">Index of element to edit</param>
        /// <param name="currentValue">Curent value that changes</param>
        /// <param name="newValue">New value</param>
        public void EditSchoolCommunityMember(int index, string currentValue, string newValue)
        {
            if (index >= 0 && index < SchoolCommunity.Length)
            {

                if (SchoolCommunity[index] is Teacher teacher)
                {
                    var elementBaseInform = teacher._baseInform;
                    if (elementBaseInform.NameOfSchool == currentValue) 
                    {
                        elementBaseInform.NameOfSchool = newValue;
                    }
                    else if (elementBaseInform.Location == currentValue)
                    {
                        elementBaseInform.Location = newValue;
                    }
                    else if (elementBaseInform.PhoneNumber == currentValue)
                    {
                        elementBaseInform.PhoneNumber = newValue;
                    }
                    else if (elementBaseInform.SchoolType == currentValue)
                    {
                        elementBaseInform.SchoolType = newValue;
                    }
                    else if (int.TryParse(currentValue, out int curentFoundingYear) && teacher._baseInform.FoundingYear == curentFoundingYear)
                    {
                        elementBaseInform.FoundingYear = curentFoundingYear;
                    }
                    else if (teacher.Name == currentValue)
                    {
                        teacher.Name = newValue;
                    }
                    else if (teacher.Specialization == currentValue)
                    {
                        teacher.Specialization = newValue;
                    }
                    else if (int.TryParse(currentValue, out int curentSeniority) && teacher.Seniority == curentSeniority)
                    {
                        teacher.Seniority = curentSeniority;
                    }
                    else if (int.TryParse(currentValue, out int currentClassroomNumber) && teacher.Seniority == currentClassroomNumber)
                    {
                        teacher.ClassroomNumber = currentClassroomNumber;
                    }

                }

                if (SchoolCommunity[index] is Schoolchild schoolChild)
                {
                    var elementBaseInform = schoolChild._baseInform;
                    if (elementBaseInform.NameOfSchool == currentValue)
                    {
                        elementBaseInform.NameOfSchool = newValue;
                    }
                    else if (elementBaseInform.Location == currentValue)
                    {
                        elementBaseInform.Location = newValue;
                    }
                    else if (elementBaseInform.PhoneNumber == currentValue)
                    {
                        elementBaseInform.PhoneNumber = newValue;
                    }
                    else if (elementBaseInform.SchoolType == currentValue)
                    {
                        elementBaseInform.SchoolType = newValue;
                    }
                    else if (int.TryParse(currentValue, out int curentFoundingYear) && schoolChild._baseInform.FoundingYear == curentFoundingYear)
                    {
                        elementBaseInform.FoundingYear = curentFoundingYear;
                    }
                    else if (schoolChild.Name == currentValue)
                    {
                        schoolChild.Name = newValue;
                    }
                    else if (double.TryParse(currentValue, out double curentAverageMark) && schoolChild.Grade == curentAverageMark)
                    {
                        schoolChild.AverageMark = curentAverageMark;
                    }
                    else if (int.TryParse(currentValue, out int curentGrade) && schoolChild.Grade == curentGrade)
                    {
                        schoolChild.Grade = curentGrade;
                    }
                    else if (int.TryParse(currentValue, out int currentNumberOfSubjects) && schoolChild.NumberOfSubjects == currentNumberOfSubjects)
                    {
                        schoolChild.NumberOfSubjects = currentNumberOfSubjects;
                    }

                }

                if (SchoolCommunity[index] is Guard guard)
                {
                    var elementBaseInform = guard._baseInform;
                    if (elementBaseInform.NameOfSchool == currentValue)
                    {
                        elementBaseInform.NameOfSchool = newValue;
                    }
                    else if (elementBaseInform.Location == currentValue)
                    {
                        elementBaseInform.Location = newValue;
                    }
                    else if (elementBaseInform.PhoneNumber == currentValue)
                    {
                        elementBaseInform.PhoneNumber = newValue;
                    }
                    else if (elementBaseInform.SchoolType == currentValue)
                    {
                        elementBaseInform.SchoolType = newValue;
                    }
                    else if (int.TryParse(currentValue, out int curentFoundingYear) && guard._baseInform.FoundingYear == curentFoundingYear)
                    {
                        elementBaseInform.FoundingYear = curentFoundingYear;
                    }
                    else if (guard.Name == currentValue)
                    {
                        guard.Name = newValue;
                    }
                    else if (guard.Shift == currentValue)
                    {
                        guard.Shift = currentValue;
                    }
                    else if (int.TryParse(currentValue, out int curentShiftDuration) && guard.ShiftDuration == curentShiftDuration)
                    {
                        guard.ShiftDuration = curentShiftDuration;
                    }
                    else if (guard.SecurityService == currentValue)
                    {
                        guard.SecurityService = currentValue;
                    }

                }
            }
            else
            {
                Errors.SetErrorCode(17);
            }
        }

        /// <summary>
        /// Return value of _schoolComunity.
        /// </summary>
        public School[] SchoolCommunity => _schoolCommunity;


        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() : $"Name of school: {_baseInform.NameOfSchool};\nLocation: {_baseInform.Location};" +
                $"\nSchool type: {_baseInform.SchoolType};\nFounding year: {_baseInform.FoundingYear};\nPhone number: {_baseInform.PhoneNumber};";

        }
    }
}
