using EF.First.Project.DAL.Contex;
using EF.First.Project.DAL.Interfaces;
using EF.First.Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.First.Project.DAL.Repositories
{
    public class UnitOfWorkEF : IUnitOfWork
    {
        private readonly Model1 _db;
        private GenericRepository<Group> _groupRepositiry;
        private GenericRepository<Audience> _audienceRepositiry;
        private GenericRepository<Speciality> _specialityRepositiry;
        private GenericRepository<Student> _studentRepositiry;
        private GenericRepository<Trainer> _trainerRepositiry;
        public UnitOfWorkEF(Model1 context)
        {
            _db = context;
        }
        public IRepository<Group> Groups => _groupRepositiry ?? (_groupRepositiry = new GenericRepository<Group>(_db));
        public IRepository<Audience> Audiences => _audienceRepositiry ?? (_audienceRepositiry = new GenericRepository<Audience>(_db));
        public IRepository<Speciality> Specialities => _specialityRepositiry ?? (_specialityRepositiry = new GenericRepository<Speciality>(_db));
        public IRepository<Student> Students => _studentRepositiry ?? (_studentRepositiry = new GenericRepository<Student>(_db));
        public IRepository<Trainer> Trainers => _trainerRepositiry ?? (_trainerRepositiry = new GenericRepository<Trainer>(_db));
        public void Save()
        {
            _db.SaveChanges();
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
