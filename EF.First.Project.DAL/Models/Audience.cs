using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Models
{
    public class Audience
    {
        public int Id { get; set; }
        public int? NumberAudience { get; set; }
        public DateTime TimeForLessons { get; set; }
    }
}
