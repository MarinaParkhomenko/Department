using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Models;
using Department.ViewModels;

namespace Department
{
    public class Queries
    {
        private readonly Data _data;

        public Queries() 
        {
            _data = new Data();
        }

        // select
        public IEnumerable<Teacher> GetTeachers()
        {
            var teachers =
                from teacher in _data.Teachers
                select teacher;

            return teachers;
        }
        // select
        public IEnumerable<Specialty> GetSpecialties()
        {
            var specialties = _data.Specialties.Select(x => x);

            return specialties;
        }
        //select, join
        public IEnumerable<SubjectInfoViewModel> GetSubjects()
        {
            var subjects =
                from subject in _data.Subjects
                join teacher in _data.Teachers 
                    on subject.TeacherId equals teacher.Id
                join subjectToSpecialty in _data.SubjectToSpecialties 
                    on subject.Id equals subjectToSpecialty.SubjectId
                join specialty in _data.Specialties 
                    on subjectToSpecialty.SpecialtyId equals specialty.Id
                select new SubjectInfoViewModel()
                {
                    Subject = subject, 
                    Teacher = teacher, 
                    Specialty = specialty 
                };

            return subjects;
        }
        //select, join
        public IEnumerable<TeacherSubjectViewModel> GetSubjectsAndTeachers()
        {
            var subjects =
                from subject in _data.Subjects
                join teacher in _data.Teachers 
                    on subject.TeacherId equals teacher.Id
                select new TeacherSubjectViewModel() 
                { 
                    Subject = subject, 
                    Teacher = teacher 
                };

            return subjects;
        }
        // select where
        public IEnumerable<Subject> SubjectsFor2Course()
        {
            var subjects = 
                from subject in _data.Subjects
                where subject.Course == 2
                select subject;

            return subjects;
        }
        // starts with
        public IEnumerable<Teacher> TeachersNameStartsWithS()
        {
            var teachers =
                from teacher in _data.Teachers
                where teacher.FirstName.StartsWith("S")
                select teacher;

            return teachers;
        }
        // order by 
        public IEnumerable<Subject> SubjectsSortedByCourse()
        {
            var subjects =
                from subject in _data.Subjects
                orderby subject.Course
                select subject;

            return subjects;
        }
        // OrderByDescending
        public IEnumerable<Subject> SubjectsSortedByCourseDescending()
        {
            return _data.Subjects.OrderByDescending(x => x.Course);
        }
        // order by, then by
        public IEnumerable<Subject> SubjectsSortedByCourseThenByHours()
        {
            return _data.Subjects.OrderBy(x => x.Course).ThenBy(x => x.Hours);
        }
        // group by
        public IEnumerable<IGrouping<int, Subject>> SubjectsGroupedByCourse()
        {
            return _data.Subjects.GroupBy(p => p.Course);
        }
        // where
        public IEnumerable<Subject> TakeSubjectsWhere()
        {
            return _data.Subjects.Where(x => x.Hours >= 3);
        }
        // take
        public IEnumerable<Subject> TakeFirst3Subjects()
        {
            return _data.Subjects.Take(3);
        }
        // contains
        public IEnumerable<Subject> SubjectWhereFormOfControl()
        {
           return _data.Subjects.Where(x => x.FormOfControl == Models.Enums.FormOfControl.notExam);
        }
        // average
        public decimal AverageHours()
        {
            return _data.Subjects.Average(x => x.Hours);
        }
        // count
        public int CountTeachers()
        {
            return _data.Teachers.Count();
        }
        // sum
        public decimal SumHoursFor2Course()
        {
            return _data.Subjects.Where(x => x.Course == 2).Sum(x => x.Hours);
        }
        // concat 
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _data.Teachers.Concat(_data.InvitedTeachers);
        }

        public string GetNames()
        {
            string allteachers = _data.Teachers
                .Aggregate("Name: ", (teacherNames, teacher)
                 => teacherNames = teacherNames + teacher.FirstName + ",");

            int LastIndex = allteachers.LastIndexOf(",");
            allteachers = allteachers.Remove(LastIndex);

            return allteachers;
        }

        // reverse
        public IEnumerable<Specialty> ReverseMethod()
        {
            return _data.Specialties.AsEnumerable().Reverse();
        }

        public IEnumerable<TeacherSubjectViewModel> JoinMethod()
        {
            var result = _data.Subjects.Join(_data.Teachers,
                subject => subject.Id,
                teacher => teacher.Id,
                (subject, teacher) => new TeacherSubjectViewModel
                {
                    Teacher = teacher,
                    Subject = subject
                });

            return result;
        }
    }
}
