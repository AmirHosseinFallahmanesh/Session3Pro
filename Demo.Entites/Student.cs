using System;

namespace Demo.Entites
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Average { get; set; }
    }


    public class Student01
    {
        public Student01(string Name, string Surname, float Average)
        {
            this.Average = Average;
            this.Name = Name;
        }
        public int StudentId { get;private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public float Average { get; private set; }


        public void UpdateAvergae(float Average)
        {
            this.Average = Average;
        }
    }
}
