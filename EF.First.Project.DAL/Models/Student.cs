using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public int StudentAge { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
