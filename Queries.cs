using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Models;
using Department.ViewModels;

namespace Department
{
    public static class Queries
    {
        // select
        public static IEnumerable<Teacher> GetTeachers()
        {
            var teachers =
                from Teacher in Data.Teachers
                select Teacher;

            return teachers;
        }
        // select
        public static IEnumerable<Specialty> GetSpecialties()
        {
            var specialties =
                from Specialty in Data.Specialties
                select Specialty;

            return specialties;
        }
        //select, join
        public static IEnumerable<SubjectInfoViewModel> GetSubjects()
        {
            var subjects =
                from Subject in Data.Subjects
                join Teacher in Data.Teachers on Subject.TeacherId equals Teacher.Id
                join SubjectToSpecialty in Data.SubjectToSpecialties on Subject.Id equals SubjectToSpecialty.SubjectId
                join Specialty in Data.Specialties on SubjectToSpecialty.SpecialtyId equals Specialty.Id
                select new SubjectInfoViewModel() { Subject = Subject, Teacher = Teacher, Specialty = Specialty };

            return subjects;
        }
        //select, join
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // переделать что-то что я уже не помню
        // убрать TeacherSubjectViewModel?
        public static IEnumerable<TeacherSubjectViewModel> GetSubjectsAndTeachers()
        {
            var subjects =
                from Subject in Data.Subjects
                join Teacher in Data.Teachers on Subject.TeacherId equals Teacher.Id
                select new TeacherSubjectViewModel() { Subject = Subject, Teacher = Teacher };

            return subjects;
        }
        // select where
        public static IEnumerable<Subject> SubjectsFor2Course()
        {
            var subjects = 
                from Subject in Data.Subjects
                where Subject.Course == 2
                select Subject;

            return subjects;
        }
        // starts with
        public static IEnumerable<Teacher> TeachersNameStartsWithS()
        {
            var teachers =
                from Teacher in Data.Teachers
                where Teacher.FirstName.StartsWith("S")
                select Teacher;

            return teachers;
        }
        // order by 
        public static IEnumerable<Subject> SubjectsSortedByCourse()
        {
            var subjects =
                from Subject in Data.Subjects
                orderby Subject.Course
                select Subject;

            return subjects;
        }
        // OrderByDescending
        public static IEnumerable<Subject> SubjectsSortedByCourseDescending()
        {
            return Data.Subjects.OrderByDescending(x => x.Course);
        }
        // order by, then by
        public static IEnumerable<Subject> SubjectsSortedByCourseThenByHours()
        {
            return Data.Subjects.OrderBy(x => x.Course).ThenBy(x => x.Hours);
        }
        // group by
        public static IEnumerable<IGrouping<int, Subject>> SubjectsGroupedByCourse()
        {
            return Data.Subjects.GroupBy(p => p.Course);
        }
        // take while
        public static IEnumerable<Subject> TakeSubjectsWhile()
        {
            return Data.Subjects.TakeWhile(x => x.Hours >= 3);
        }
        // take
        public static IEnumerable<Subject> TakeFirst3Subjects()
        {
            return Data.Subjects.Take(3);
        }
        // contains
        public static IEnumerable<Subject> SubjectContains()
        {
            return Data.Subjects.Where(x => x.FormOfControl.Contains("exam"));
        }
        // average
        public static decimal AverageHours()
        {
            return Data.Subjects.Average(x => x.Hours);
        }
        // count
        public static int CountTeachers()
        {
            return Data.Subjects.Count();
        }
        // sum
        public static decimal SumHoursFor2Course()
        {
            return Data.Subjects.Where(x => x.Course == 2).Sum(x => x.Hours);
        }
        // reverse
        public static IEnumerable<Specialty> ReverseMethod()
        {
            return Data.Specialties.AsEnumerable().Reverse();
        }
    }
}
