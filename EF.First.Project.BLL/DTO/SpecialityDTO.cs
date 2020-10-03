using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.BLL.DTO
{
    class SpecialityDTO
    {
        public int Id { get; set; }
        public string NameSpeciality { get; set; }
        public int TimeForStudyInMonth { get; set; }
        public ICollection<GroupDTO> Groups { get; set; }
        public SpecialityDTO()
        {
            Groups = new List<GroupDTO>();
        }
    }
}
