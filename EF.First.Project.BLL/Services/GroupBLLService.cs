using AutoMapper;
using EF.First.Project.BLL.DTO;
using EF.First.Project.BLL.Interfaces;
using EF.First.Project.DAL.Interfaces;
using EF.First.Project.DAL.Models;
using System;
using System.Collections.Generic;

namespace EF.First.Project.BLL.Services
{
    class GroupBLLService : IBLLService<GroupDTO>, IDisposable
    {
        private readonly IMapper _mapper = Mapper.Instance;
        IUnitOfWork db { get; }
        public GroupBLLService(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }
        public IEnumerable<GroupDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<GroupDTO>>(db.Groups.GetAll());
        }
        public GroupDTO GetById(int id)
        {
            return _mapper.Map<GroupDTO>(db.Groups.Get(id));
        }
        public bool Add(GroupDTO groupDTO)
        {
            if (groupDTO == null)
            {
                throw new ArgumentNullException();
            }
            var group = _mapper.Map<Group>(groupDTO);
            group.GroupName = groupDTO.GroupName;
            group.CountOfStudents = groupDTO.CountOfStudents;
            group.IdSpeciality = groupDTO.IdSpeciality;
            group.TrainerId = groupDTO.TrainerId;
            return true;
        }
        public bool Edit(GroupDTO groupDTO)
        {
            if (groupDTO == null)
            {
                throw new ArgumentNullException();
            }
            var group = _mapper.Map<Group>(groupDTO);
            group.GroupName = groupDTO.GroupName;
            group.CountOfStudents = groupDTO.CountOfStudents;
            group.IdSpeciality = groupDTO.IdSpeciality;
            group.TrainerId = groupDTO.TrainerId;
            return true;
        }
        public bool Delete(int id)
        {
            var group = db.Groups.Get(id);
            if (group == null)
            {
                throw new ArgumentNullException();
            }
            db.Groups.Delete(group.Id);
            return true;
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
