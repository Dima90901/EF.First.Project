using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int CountOfStudents { get; set; }
        public int TrainerId { get; set; }
        public int IdSpeciality { get; set; }
        public Trainers Trainers { get; set; }
        public Speciality Speciality { get; set; }
        public ICollection<Students> Students { get; set; }
        public Group()
        {
            Students = new List<Students>();
        }

    }
    public class Trainers
    {
        public int TrainerId { get; set; }
        public string Name { get; set; }
        public int ExpWorkInYears { get; set; }
        public ICollection<Group> Groups { get; set; }
        public Trainers ()
        {
            Groups = new List<Group>();
        }
    }
    public class Speciality
    {
        public int IdSpeciality { get; set; }
        public string NameSpeciality { get; set; }
        public int TimeForStudyInMonth { get; set; }
        public ICollection<Group> Groups { get; set; }
        public Speciality()
        {
            Groups = new List<Group>();
        }
    }
    public class Audience
    {
        public int? NumberAudience { get; set; }
        public DateTime TimeForLessons { get; set; }
    }
    public class Students
    {
        public int IdStudent { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public int StudentAge { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
