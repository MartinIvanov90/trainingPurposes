using System;
using BlueVsWhiteColar.Abstract;
namespace BlueVsWhiteColar.Bussines
{
    class Student : Human
    {

        private readonly int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
        }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.grade = grade;
        }
    }
}
