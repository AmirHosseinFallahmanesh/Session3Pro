using Demo.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Contracts.DomainService
{
    public  interface IStudentService
    {

         int Add(Student student);

         IEnumerable<Student> GetAll();

    }
}
