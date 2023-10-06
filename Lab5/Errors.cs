
namespace Lab5
{
    internal class Errors
    {
        private static int _errorCode = 0;

        /// <summary>
        /// Setter and getter for the error code.
        /// </summary>
        public static int ErrorCode
        {
            get => _errorCode;
            set => _errorCode = value;
        }

        /// <summary>
        /// Sets the value of the _errorCode field.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public static void SetErrorCode(int errorCode) {
            ErrorCode = errorCode;
        }

        static string[] errorsArray = {
            "",
            "Incorrect name of school!",
            "Incorrect location!",
            "Incorrect phone number!",
            "Incorrect school type!",
            "Incorrect founding year!",
            "Can't delete this element/incorrect index!",
            "Incorrect name!",
            "Incorrect specialization data!",
            "Incorrect seniority data!",
            "Incorrect number of classroom!",
            "Incorrect average mark!",
            "Incorrect grade!",
            "Incorrect number of subjects!",
            "Incorrect shift data!",
            "Incorrect shift duration!",
            "Incorrect security service data!",
            "Can't edit this element/incorrect index!"
        };

        /// <summary>
        /// Return curent error.
        /// </summary>
        /// <returns>Current error.</returns>
        public static string GetError()
        {
            return errorsArray[ErrorCode];
        }
    }
}
