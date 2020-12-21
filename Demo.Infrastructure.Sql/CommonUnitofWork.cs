using Demo.Infrastructure.Sql.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Sql
{
   public class CommonUnitofWork
    {
        public DemoContext context;
        public CommonUnitofWork()
        {
            context = new DemoContext();
        }

        public StudentRepository StudentRepository { get; set; }
        public TeacherRepository TeacherRepository { get; set; }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
