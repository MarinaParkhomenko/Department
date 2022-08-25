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
            Queries queries = new Queries();
            ConsoleWriter consoleWriter = new ConsoleWriter();

            // display teachers
            Console.WriteLine("Teachers: ");
            var teachers = queries.GetTeachers();
            consoleWriter.GetTeachers(teachers);

            // display specialties
            Console.WriteLine("Specialties: ");
            var specialties = queries.GetSpecialties();
            consoleWriter.GetSpecialties(specialties);

            // display subjects
            Console.WriteLine("Subjects: ");
            var subjects = queries.GetSubjects();
            consoleWriter.GetSubjects(subjects);

            // display subjects and their teachers
            Console.WriteLine("Subjects and their teachers: ");
            var subjectsteachers = queries.GetSubjectsAndTeachers();
            consoleWriter.GetSubjectsAndTeachers(subjectsteachers);

            // display subjecst for second course
            Console.WriteLine("Subjects for second course: ");
            var subjectsfor2course = queries.SubjectsFor2Course();
            consoleWriter.SubjectsFor2Course(subjectsfor2course);


            // display teachers whose names start with S
            Console.WriteLine("Teachers whose names start with S: ");
            var teachersWithS = queries.TeachersNameStartsWithS();
            consoleWriter.TeachersNameStartsWithS(teachersWithS);

            // display subjecst sorted by course
            Console.WriteLine("Subjects sorted by course: ");
            var subjectssortedbycourse = queries.SubjectsSortedByCourse();
            consoleWriter.SubjectsSortedByCourse(subjectssortedbycourse);

            // display subjecst sorted by course descending
            Console.WriteLine("Subjects sorted by course descending: ");
            var subjectssortedbycoursedes = queries.SubjectsSortedByCourseDescending();
            consoleWriter.SubjectsSortedByCourseDescending(subjectssortedbycoursedes);

            // display subjecst sorted by course then by hours
            Console.WriteLine("Subjects sorted by course then by hours: ");
            var subjectssortedbycoursethenbyhours = queries.SubjectsSortedByCourseThenByHours();
            consoleWriter.SubjectsSortedByCourseThenByHours(subjectssortedbycoursethenbyhours);

            // display subjects grouped by course
            Console.WriteLine("Subjects grouped by course: ");
            var subjectsgroupedbycourse = queries.SubjectsGroupedByCourse();
            consoleWriter.SubjectsGroupedByCourse(subjectsgroupedbycourse);

            // display subjects where hours >= 3
            Console.WriteLine("Subjects where hours >= 3: ");
            var subjectswhile = queries.TakeSubjectsWhere();
            consoleWriter.TakeSubjectsWhere(subjectswhile);

            // display first 3 subjects on the list
            Console.WriteLine("Take first 3 subjects on the list: ");
            var first3subjects = queries.TakeFirst3Subjects();
            consoleWriter.TakeFirst3Subjects(first3subjects);

            // display subjects that contain "not exam"
            Console.WriteLine("Take subjects where form of control is 'not exam': ");
            var subjectcontains = queries.SubjectWhereFormOfControl();
            consoleWriter.SubjectWhereFormOfControl(subjectcontains);

            // display average hours
            var averagehours = queries.AverageHours();
            consoleWriter.AverageHours(averagehours);

            // count teachers
            var countteachers = queries.CountTeachers();
            consoleWriter.CountTeachers(countteachers);

            // total hours for 2 course
            var totalhours = queries.SumHoursFor2Course();
            consoleWriter.SumHoursFor2Course(totalhours);

            // get all teachers
            Console.WriteLine("Get all teachers: ");
            var allteachers = queries.GetAllTeachers();
            consoleWriter.GetAllTeachers(allteachers);

            // display all teachers names as a string
            Console.WriteLine("Get all teachers names: ");
            var allnames = queries.GetNames();
            consoleWriter.GetNames(allnames);

            // reverse method
            Console.WriteLine("Specialties in reverse: ");
            var reversemethod = queries.ReverseMethod();
            consoleWriter.ReverseMethod(reversemethod);

            // join
            Console.WriteLine("Join subjects and teachers: ");
            var joinmethod = queries.JoinMethod();
            consoleWriter.JoinMethod(joinmethod);
        }
    }
}