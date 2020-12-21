using Demo.Contracts.DomainService;
using Demo.Contracts.Repositories;
using Demo.Infrastructure.Sql;
using Demo.Infrastructure.Sql.Repositories;
using Demo.Services;
using System;

namespace EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repository = new StudentRepository();
            IStudentService student = new StudentService(repository);
            student.Add(new Demo.Entites.Student() { Name = "amir", Surname = "amiri" });
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
