using Demo.Contracts.DomainService;
using Demo.Contracts.Repositories;
using Demo.Entites;
using Demo.Infrastructure.Sql;
using System;
using System.Collections.Generic;

namespace Demo.Services
{
    public class StudentService : IStudentService
    {
        private readonly CommonUnitofWork uow;

        public StudentService(CommonUnitofWork uow)
        {
            this.uow = uow;
        }
        public int Add(Student student)
        {
           return uow.StudentRepository.Add(student);
        }

        public IEnumerable<Student> GetAll()
        {
            return uow.StudentRepository.GetAll();
        }
    }
}
