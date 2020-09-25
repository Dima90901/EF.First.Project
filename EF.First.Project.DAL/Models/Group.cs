using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int CountOfStudents { get; set; }
        public int? TrainerId { get; set; }
        public int? IdSpeciality { get; set; }
        public Trainer Trainers { get; set; }
        public Speciality Speciality { get; set; }
        public ICollection<Student> Students { get; set; }
        public Group()
        {
            Students = new List<Student>();
        }

    }
}
