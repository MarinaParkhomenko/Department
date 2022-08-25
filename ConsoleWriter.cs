using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Models;
using Department.ViewModels;

namespace Department
{
    public class ConsoleWriter
    {
        public void GetTeachers(IEnumerable<Teacher> list)
        {
            foreach (Teacher teacher in list)
            {
                Console.WriteLine(teacher.Id + ". " + teacher.FirstName + " " + teacher.LastName);
                Console.WriteLine();
            }
        }

        public void GetSpecialties(IEnumerable<Specialty> list)
        {
            foreach (Specialty specialty in list)
            {
                Console.WriteLine(specialty.Id + ". " + specialty.Code + " " + specialty.Name);
                Console.WriteLine();
            }
        }

        public void GetSubjects(IEnumerable<SubjectInfoViewModel> list)
        {
            foreach(SubjectInfoViewModel subject in list)
            {
                Console.WriteLine(subject.Subject.Id + ". " + subject.Subject.Name);
                Console.WriteLine(subject.Teacher.FirstName + " " + subject.Teacher.LastName);
                Console.WriteLine(subject.Subject.FormOfControl);
                Console.WriteLine(subject.Subject.Hours + " hours");
                Console.WriteLine("Course " + subject.Subject.Course);
                Console.WriteLine(subject.Specialty.Code + " " + subject.Specialty.Name);
                Console.WriteLine();
            }
        }

        public void GetSubjectsAndTeachers(IEnumerable<TeacherSubjectViewModel> list)
        {
            foreach (TeacherSubjectViewModel subject in list)
            {
                Console.WriteLine(subject.Subject.Id + ". " + subject.Subject.Name);
                Console.WriteLine(subject.Teacher.FirstName + " " + subject.Teacher.LastName);
                Console.WriteLine("Course " + subject.Subject.Course);
                Console.WriteLine();
            }
        }

        public void SubjectsFor2Course(IEnumerable<Subject> list)
        {
            foreach(Subject subject in list)
            {
                Console.WriteLine(subject.Id + ". " + subject.Name);
                Console.WriteLine(subject.FormOfControl);
                Console.WriteLine(subject.Hours + " hours");
                Console.WriteLine();
            }
        }

        public void TeachersNameStartsWithS(IEnumerable<Teacher> list)
        {
            foreach(Teacher teacher in list)
            {
                Console.WriteLine(teacher.Id + ". " + teacher.FirstName + " " + teacher.LastName);
                Console.WriteLine();
            }
        }

        public void SubjectsSortedByCourse(IEnumerable<Subject> list)
        {
            foreach (Subject subject in list)
            {
                Console.WriteLine(subject.Id + ". " + subject.Name);
                Console.WriteLine(subject.FormOfControl);
                Console.WriteLine(subject.Hours + " hours");
                Console.WriteLine("Course " + subject.Course);
                Console.WriteLine();
            }
        }

        public void SubjectsSortedByCourseDescending(IEnumerable<Subject> list)
        {
            foreach (Subject subject in list)
            {
                Console.WriteLine(subject.Id + ". " + subject.Name);
                Console.WriteLine(subject.FormOfControl);
                Console.WriteLine(subject.Hours + " hours");
                Console.WriteLine("Course " + subject.Course);
                Console.WriteLine();
            }
        }

        public void SubjectsSortedByCourseThenByHours(IEnumerable<Subject> list)
        {
            foreach (Subject subject in list)
            {
                Console.WriteLine(subject.Id + ". " + subject.Name);
                Console.WriteLine(subject.FormOfControl);
                Console.WriteLine(subject.Hours + " hours");
                Console.WriteLine("Course " + subject.Course);
                Console.WriteLine();
            }
        }

        public void SubjectsGroupedByCourse(IEnumerable<IGrouping<int, Subject>> list)
        {
            foreach(var group in list)
            {
                var groupkey = group.Key;
                Console.WriteLine("Course: " + groupkey);

                foreach (var subject in group)
                {
                    Console.WriteLine(subject.Id + ". " + subject.Name);
                    Console.WriteLine(subject.FormOfControl);
                    Console.WriteLine(subject.Hours + " hours");
                    Console.WriteLine();
                }
            }
        }

        public void TakeSubjectsWhere(IEnumerable<Subject> list)
        {
            foreach(Subject subject in list)
            {
                Console.WriteLine(subject.Id + ". " + subject.Name);
                Console.WriteLine(subject.Hours + " hours");
                Console.WriteLine();
            }
        }

        public void TakeFirst3Subjects(IEnumerable<Subject> list)
        {
            foreach (Subject subject in list)
            {
                Console.WriteLine(subject.Id + ". " + subject.Name);
                Console.WriteLine();
            }
        }

        public void SubjectWhereFormOfControl(IEnumerable<Subject> list)
        {
            foreach (Subject subject in list)
            {
                Console.WriteLine(subject.Id + ". " + subject.Name);
                Console.WriteLine(subject.FormOfControl);
                Console.WriteLine();
            }
        }

        public void AverageHours(decimal hours)
        {
            Console.WriteLine("Average hours: " + hours);
            Console.WriteLine();
        }

        public void CountTeachers(int count)
        {
            Console.WriteLine("Teachers: " + count);
            Console.WriteLine();
        }

        public void SumHoursFor2Course(decimal hours)
        {
            Console.WriteLine("Course: 2");
            Console.WriteLine("Total hours: " + hours);
            Console.WriteLine();
        }

        public void GetAllTeachers(IEnumerable<Teacher> list)
        {
            foreach (Teacher teacher in list)
            {
                Console.WriteLine(teacher.Id + ". " + teacher.FirstName + " " + teacher.LastName);
                Console.WriteLine();
            }
        }

        public void GetNames(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine();
        }

        public void ReverseMethod(IEnumerable<Specialty> list)
        {
            foreach(Specialty specialty in list)
            {
                Console.WriteLine(specialty.Id + ". " + specialty.Code + " " + specialty.Name);
                Console.WriteLine();
            }
        }

        public void JoinMethod(IEnumerable<TeacherSubjectViewModel> list)
        {
            foreach (TeacherSubjectViewModel subject in list)
            {
                Console.WriteLine(subject.Subject.Id + ". " + subject.Subject.Name);
                Console.WriteLine(subject.Teacher.FirstName + " " + subject.Teacher.LastName);
                Console.WriteLine();
            }
        }
    }
}
