using AutoMapper;
using EF.First.Project.BLL.DTO;
using EF.First.Project.BLL.Interfaces;
using EF.First.Project.DAL.Interfaces;
using EF.First.Project.DAL.Models;
using System;
using System.Collections.Generic;

namespace EF.First.Project.BLL.Services
{
    public class AudienceBLLService : IDisposable, IBLLService<AudienceDTO>
    {
        private readonly IMapper _mapper = Mapper.Instance;
        IUnitOfWork db { get; }
        public AudienceBLLService(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }
        public IEnumerable<AudienceDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<AudienceDTO>>(db.Audiences.GetAll());
        }
        public AudienceDTO GetById(int id)
        {
            return _mapper.Map<AudienceDTO>(db.Audiences.Get(id));
        }
        public bool Add(AudienceDTO audienceDTO)
        {
            if (audienceDTO == null)
            {
                throw new ArgumentNullException();
            }
            var audience = _mapper.Map<Audience>(audienceDTO);
            audience.NumberAudience = audienceDTO.NumberAudience;
            audience.TimeForLessons = audienceDTO.TimeForLessons;
            return true;
        }
        public bool Edit(AudienceDTO audienceDTO)
        {
            if (audienceDTO == null)
            {
                throw new ArgumentNullException();
            }
            var audience = db.Audiences.Get(audienceDTO.Id);
            audience.NumberAudience = audienceDTO.NumberAudience;
            audience.TimeForLessons = audienceDTO.TimeForLessons;
            return true;
        }
        public bool Delete(int id)
        {
            var audience = db.Audiences.Get(id);
            if (audience == null)
            {
                throw new ArgumentNullException();
            }
            db.Audiences.Delete(audience.Id);
            return true;
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
