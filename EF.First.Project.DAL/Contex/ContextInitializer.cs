using EF.First.Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Contex
{
    class ContextInitializer : DropCreateDatabaseIfModelChanges<Model1>
    {
        protected override void Seed(Model1 context)
        {
            base.Seed(context);
            Audience audiences = new Audience()
            {
                NumberAudience = 1,
                TimeForLessons = new DateTime(2020, 10, 2, 19, 00, 00)
            };
            context.Audiences.Add(audiences);
            Group group = new Group()
            {
                CountOfStudents = 3,
                GroupName = ".NET dev",
                IdSpeciality = 1,
                TrainerId = 1,
            };
            context.Groups.Add(group);
            Speciality speciality = new Speciality()
            {
                NameSpeciality = ".NET fullstack developer",
                TimeForStudyInMonth = 40
            };
            context.Specialities.Add(speciality);
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    GroupId = 1,
                    StudentAge = 30,
                    StudentFName = "Dima",
                    StudentLName = "Pasichnyi"
                },
                new Student
                {
                    GroupId = 1,
                    StudentAge = 30,
                    StudentFName = "Anton",
                    StudentLName = "Byrko"
                },
                new Student
                {
                    GroupId = 1,
                    StudentAge = 30,
                    StudentFName = "Sherhan",
                    StudentLName = "Tagubaev"
                }
            };
            context.Students.AddRange(students);
            Trainer trainer = new Trainer()
            {
                ExpWorkInYears = 5,
                Name = "Roman"
            };
            context.Trainers.Add(trainer);
            context.SaveChanges();
        }
    }
}
