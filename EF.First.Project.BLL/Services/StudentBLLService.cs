using AutoMapper;
using EF.First.Project.BLL.DTO;
using EF.First.Project.BLL.Interfaces;
using EF.First.Project.DAL.Interfaces;
using EF.First.Project.DAL.Models;
using System;
using System.Collections.Generic;

namespace EF.First.Project.BLL.Services
{
    public class StudentBLLService : IBLLService<StudentDTO>, IDisposable
    {
        private readonly IMapper _mapper = Mapper.Instance;
        IUnitOfWork db { get; }
        public StudentBLLService(IUnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }
        public IEnumerable<StudentDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<StudentDTO>>(db.Students.GetAll());
        }
        public StudentDTO GetById(int id)
        {
            return _mapper.Map<StudentDTO>(db.Students.Get(id));
        }
        public bool Add(StudentDTO studentDTO)
        {
            if (studentDTO == null)
            {
                throw new ArgumentNullException();
            }
            var student = _mapper.Map<Student>(studentDTO);
            student.StudentAge = studentDTO.StudentAge;
            student.StudentFName = studentDTO.StudentFName;
            student.StudentLName = studentDTO.StudentLName;
            return true;
        }
        public bool Edit(StudentDTO studentDTO)
        {
            if (studentDTO == null)
            {
                throw new ArgumentNullException();
            }
            var student = _mapper.Map<Student>(studentDTO);
            student.StudentAge = studentDTO.StudentAge;
            student.StudentFName = studentDTO.StudentFName;
            student.StudentLName = studentDTO.StudentLName;
            return true;
        }
        public bool Delete(int id)
        {
            var group = db.Students.Get(id);
            if (group == null)
            {
                throw new ArgumentNullException();
            }
            db.Students.Delete(group.Id);
            return true;
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
