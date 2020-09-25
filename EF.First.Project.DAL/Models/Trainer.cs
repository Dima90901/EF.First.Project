using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExpWorkInYears { get; set; }
        public ICollection<Group> Groups { get; set; }
        public Trainer()
        {
            Groups = new List<Group>();
        }
    }

}
