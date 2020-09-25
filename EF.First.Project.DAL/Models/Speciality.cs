using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string NameSpeciality { get; set; }
        public int TimeForStudyInMonth { get; set; }
        public ICollection<Group> Groups { get; set; }
        public Speciality()
        {
            Groups = new List<Group>();
        }
    }
}
