using System.Diagnostics.Metrics;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("NUOP", "Odesa", "Junior school", 1980, "+380111111111", "Lizabeth", "Mathematic", 20, 111);
            Schoolchild schoolchild = new Schoolchild("School1", "Kyiv", "Gymnazium", 2000, "+380888888888", "Alex", 10.5, 10, 15);
            Schoolchild schoolchild2 = new Schoolchild("DUOP", "Kharkiv", "Medium school", 1850, "+380222222222", "Igor", 8.4, 4, 5);
            Guard guard = new Guard("DUOP", "Lviv", "High school", 2015, "+380333333333", "Joe", "Day", 10, "SecComService");

            School schoolCommunity = new School();
            schoolCommunity.AddMember(teacher);
            schoolCommunity.AddMember(schoolchild);
            schoolCommunity.AddMember(guard);
            schoolCommunity.AddMember(schoolchild2);

            foreach (var member in schoolCommunity.SchoolCommunity)
            {
                Console.WriteLine("--------------------------------------------\n" + member);
            }
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("Delete element #2");
            Console.WriteLine("////////////////////////////////////////////////////////////");
            schoolCommunity.DeleteMember(1);
            foreach (var member in schoolCommunity.SchoolCommunity)
            {
                Console.WriteLine("--------------------------------------------\n" + member);
            }
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("Edit element 1");
            Console.WriteLine("////////////////////////////////////////////////////////////");

            schoolCommunity.EditSchoolCommunityMember(0, "NUOP", "Edit name");
            Console.WriteLine(schoolCommunity.SchoolCommunity[0]);
        }
    }
}