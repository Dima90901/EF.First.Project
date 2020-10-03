using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.BLL.DTO
{
    class GroupDTO
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public int CountOfStudents { get; set; }
        public int? TrainerId { get; set; }
        public int? IdSpeciality { get; set; }
        public TrainerDTO Trainers { get; set; }
        public SpecialityDTO Speciality { get; set; }
        public ICollection<StudentDTO> Students { get; set; }
        public GroupDTO()
        {
            Students = new List<StudentDTO>();
        }
    }
}
