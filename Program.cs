using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Models;
using Department.ViewModels;




namespace Department
{
    class Program
    {
        static void Main(string[] args)
        {
            // display teachers
            Console.WriteLine("Teachers: ");
            var teachers = Queries.GetTeachers();
            ConsoleWriter.GetTeachers(teachers);

            // display specialties
            Console.WriteLine("Specialties: ");
            var specialties = Queries.GetSpecialties();
            ConsoleWriter.GetSpecialties(specialties);

            // display subjects
            Console.WriteLine("Subjects: ");
            var subjects = Queries.GetSubjects();
            ConsoleWriter.GetSubjects(subjects);

            // display subjects and their teachers
            Console.WriteLine("Subjects and their teachers: ");
            var subjectsteachers = Queries.GetSubjectsAndTeachers();
            ConsoleWriter.GetSubjectsAndTeachers(subjectsteachers);

            // display subjecst for second course
            Console.WriteLine("Subjects for second course: ");
            var subjectsfor2course = Queries.SubjectsFor2Course();
            ConsoleWriter.SubjectsFor2Course(subjectsfor2course);


            // display teachers whose names start with S
            Console.WriteLine("Teachers whose names start with S: ");
            var teachersWithS = Queries.TeachersNameStartsWithS();
            ConsoleWriter.TeachersNameStartsWithS(teachersWithS);

            // display subjecst sorted by course
            Console.WriteLine("Subjects sorted by course: ");
            var subjectssortedbycourse = Queries.SubjectsSortedByCourse();
            ConsoleWriter.SubjectsSortedByCourse(subjectssortedbycourse);

            // display subjecst sorted by course descending
            Console.WriteLine("Subjects sorted by course: ");
            var subjectssortedbycoursedes = Queries.SubjectsSortedByCourseDescending();
            ConsoleWriter.SubjectsSortedByCourseDescending(subjectssortedbycoursedes);

            // display subjecst sorted by course then by hours
            Console.WriteLine("Subjects sorted by course then by hours: ");
            var subjectssortedbycoursethenbyhours = Queries.SubjectsSortedByCourseThenByHours();
            ConsoleWriter.SubjectsSortedByCourseThenByHours(subjectssortedbycoursethenbyhours);

            // display subjects grouped by course
            Console.WriteLine("Subjects grouped by course: ");
            var subjectsgroupedbycourse = Queries.SubjectsGroupedByCourse();
            ConsoleWriter.SubjectsGroupedByCourse(subjectsgroupedbycourse);

            // display subjects where hours >= 3
            // неработает!!!!!!!!!!!!!!!!!!
            Console.WriteLine("Subjects where hours >= 3: ");
            var subjectswhile = Queries.TakeSubjectsWhile();
            ConsoleWriter.TakeSubjectsWhile(subjectswhile);

            // display first 3 subjects on the list
            Console.WriteLine("Take first 3 subjects on the list: ");
            var first3subjects = Queries.TakeFirst3Subjects();
            ConsoleWriter.TakeFirst3Subjects(first3subjects);

            // display subjects that contain "exam"
            Console.WriteLine("Take first 3 subjects on the list: ");
            var subjectcontains = Queries.SubjectContains();
            ConsoleWriter.SubjectContains(subjectcontains);

            // display average hours
            var averagehours = Queries.AverageHours();
            ConsoleWriter.AverageHours(averagehours);

            // count teachers
            var countteachers = Queries.CountTeachers();
            ConsoleWriter.CountTeachers(countteachers);

            // total hours for 2 course
            var totalhours = Queries.SumHoursFor2Course();
            ConsoleWriter.SumHoursFor2Course(totalhours);

            // reverse method
            var reversemethod = Queries.ReverseMethod();
            ConsoleWriter.ReverseMethod(reversemethod);
        }
    }
}