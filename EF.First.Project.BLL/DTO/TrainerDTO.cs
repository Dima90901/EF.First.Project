using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.BLL.DTO
{
    public class TrainerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExpWorkInYears { get; set; }
        public ICollection<GroupDTO> Groups { get; set; }
        public TrainerDTO()
        {
            Groups = new List<GroupDTO>();
        }
    }
}
