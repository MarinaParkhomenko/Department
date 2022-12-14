using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Models;
using Department.Models.Enums;

namespace Department
{
    public class Data
    {
        public List<Teacher> Teachers =>
            new List<Teacher>
            {
                new Teacher()
                {
                    Id = 1,
                    FirstName = "Svetlana",
                    LastName = "Proskura"
                },

                new Teacher()
                {
                    Id = 2,
                    FirstName = "Yulia",
                    LastName = "Kramar"
                },

                new Teacher()
                {
                    Id = 3,
                    FirstName = "Olena",
                    LastName = "Halus"
                },

                new Teacher()
                {
                    Id = 4,
                    FirstName = "Volodya",
                    LastName = "Popenko"
                },

                new Teacher()
                {
                    Id = 5,
                    FirstName = "Natalia",
                    LastName = "Bogdanova"
                }
            };

        public List<Teacher> InvitedTeachers =>
            new List<Teacher>
            {
                new Teacher()
                {
                    Id = 1,
                    FirstName = "Mark",
                    LastName = "Markson"
                },

                new Teacher()
                {
                    Id = 2,
                    FirstName = "Nick",
                    LastName = "Nicholson"
                }
            };

        public List<Specialty> Specialties =>
            new List<Specialty>
            {
                new Specialty()
                {
                    Id = 1,
                    Name = "Software Engineering",
                    Code = 121
                },
                
                new Specialty()
                {
                    Id = 2,
                    Name = "Information systems and technologies",
                    Code = 126
                },

                new Specialty()
                {
                    Id = 3,
                    Name = "Computer Engineering",
                    Code = 123
                }
            };

        public List<SubjectToSpecialty> SubjectToSpecialties =>
            new List<SubjectToSpecialty>
            {
                new SubjectToSpecialty()
                {
                    SubjectId = 1,
                    SpecialtyId = 1
                },

                new SubjectToSpecialty()
                {
                    SubjectId = 1,
                    SpecialtyId = 2
                },

                new SubjectToSpecialty()
                {
                    SubjectId = 1,
                    SpecialtyId = 3
                },

                new SubjectToSpecialty()
                {
                    SubjectId = 2,
                    SpecialtyId = 3
                },

                new SubjectToSpecialty()
                {
                    SubjectId = 3,
                    SpecialtyId = 2
                },

                new SubjectToSpecialty()
                {
                    SubjectId = 4,
                    SpecialtyId = 1
                },

                new SubjectToSpecialty()
                {
                    SubjectId = 5,
                    SpecialtyId = 2
                },

                new SubjectToSpecialty()
                {
                    SubjectId = 6,
                    SpecialtyId = 1
                },
            };

        public List<Subject> Subjects =>
            new List<Subject>
            {
                new Subject()
                {
                    Id = 1,
                    Name = "Higher math",
                    TeacherId = 1,
                    FormOfControl = FormOfControl.Exam,
                    Hours = 7,
                    Course = 2
                },
                new Subject()
                {
                    Id = 2,
                    Name = "Physics",
                    TeacherId = 2,
                    FormOfControl = FormOfControl.notExam,
                    Hours = 3,
                    Course = 1
                },
                new Subject()
                {
                    Id = 3,
                    Name = "Logic",
                    TeacherId = 3,
                    FormOfControl = FormOfControl.notExam,
                    Hours = 1,
                    Course = 3
                },
                new Subject()
                {
                    Id = 4,
                    Name = ".net",
                    TeacherId = 4,
                    FormOfControl = FormOfControl.notExam,
                    Hours = 5,
                    Course = 2
                },
                new Subject()
                {
                    Id = 5,
                    Name = "Web",
                    TeacherId = 5,
                    FormOfControl = FormOfControl.Exam,
                    Hours = 7,
                    Course = 2
                },
                new Subject()
                {
                    Id = 6,
                    Name = "Databases",
                    TeacherId = 5,
                    FormOfControl = FormOfControl.Exam,
                    Hours = 4,
                    Course = 1
                }
            };
    }
}
