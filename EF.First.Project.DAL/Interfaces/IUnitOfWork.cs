using EF.First.Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        IRepository<Group> Groups { get; }
        IRepository<Audience> Audiences { get; }
        IRepository<Speciality> Specialities { get; }
        IRepository<Student> Students { get; }
        IRepository<Trainer> Trainers { get; }
        void Save();
    }
}
