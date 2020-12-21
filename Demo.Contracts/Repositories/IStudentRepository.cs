using Demo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Contracts.Repositories
{
    public interface IStudentRepository
    {
        int Add(Student student);

        List<Student> GetAll();

        Student GetByName(string name);

    }
}
