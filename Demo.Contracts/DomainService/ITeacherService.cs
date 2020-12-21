using Demo.Entites;
using System.Collections.Generic;

namespace Demo.Contracts.DomainService
{
    public interface ITeacherService
    {

        int Add(Teacher student);

        Teacher Get(int id);
        List<Student> GetAll();

    }
}
