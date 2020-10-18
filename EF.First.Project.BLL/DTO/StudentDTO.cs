using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.BLL.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public int StudentAge { get; set; }
        public int GroupId { get; set; }
        public GroupDTO Group { get; set; }
    }
}
