using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Student : Person
    {
        DateTime dateOfBirth;
        string course;

        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Course { get => course; set => course = value; }

        public Student() { }

        public Student(string name, string surname, int age, DateTime dateOfBirth, string course) : base(name, surname, age)
        {
            DateOfBirth = dateOfBirth;
            Course = course;
        }

        public override string ToString()
        {
            return base.ToString() + $"Дата рождения: {DateOfBirth, -10}Курс обучения: {Course}";
        }
    }
}
