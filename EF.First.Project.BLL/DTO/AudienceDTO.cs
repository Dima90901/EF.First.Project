using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.BLL.DTO
{
    public class AudienceDTO
    {
        public int Id { get; set; }
        public int? NumberAudience { get; set; }
        public DateTime TimeForLessons { get; set; }
    }
}
