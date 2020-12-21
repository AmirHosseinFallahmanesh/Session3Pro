using Demo.Contracts.Repositories;
using Demo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Infrastructure.Sql.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DemoContext context;

        public StudentRepository(DemoContext context)
        {
            this.context = context;
        }
        public int Add(Student student)
        {
            context.Students.Add(student);
        
            return student.StudentId;
        }

        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public Student GetByName(string name)
        {
            return context.Students.First(a=>a.Name==name);
        }
    }


    public class TeacherRepository : ITeacherRepository
    {
        private readonly DemoContext context;

        public TeacherRepository(DemoContext context)
        {
            this.context = context;
        }
        public int Add(Teacher student)
        {
            context.Teachers.Add(student);
          
            return student.TeacherId;
        }
    }
}
