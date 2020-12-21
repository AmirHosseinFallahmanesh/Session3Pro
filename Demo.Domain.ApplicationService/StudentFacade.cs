using Demo.Contracts.DomainService;
using Demo.Entites;
using Demo.Infrastructure.Sql;
using System;

namespace Demo.Domain.ApplicationService
{
    public class StudentFacade
    {
        private readonly IStudentService studentService;
        private readonly ITeacherService teacherService;
        private readonly CommonUnitofWork commonUnitofWork;

        public StudentFacade(IStudentService studentService,
            ITeacherService teacherService,
            CommonUnitofWork commonUnitofWork)
        {
            this.studentService = studentService;
            this.teacherService = teacherService;
            this.commonUnitofWork = commonUnitofWork;
        }


        public void AddStudent(Student student,Teacher teacher)
        {
            try
            {
                studentService.Add(student);
                teacherService.Add(teacher);

                commonUnitofWork.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
      
        }


    }
}
