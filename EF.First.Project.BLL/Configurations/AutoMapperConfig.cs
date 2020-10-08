using AutoMapper;
using EF.First.Project.BLL.DTO;
using EF.First.Project.DAL.Models;

namespace EF.First.Project.BLL.Configurations
{
    class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Audience, AudienceDTO>().ReverseMap();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<Speciality, SpecialityDTO>().ReverseMap();
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Trainer, TrainerDTO>().ReverseMap();
        }
        public static void Initialize()
        {
            Mapper.Initialize(cnf => cnf.AddProfile<AutoMapperConfig>());
        }
    }
}
