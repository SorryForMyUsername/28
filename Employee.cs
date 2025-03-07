using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    /// <summary>
    /// Сотрудник предприятия
    /// </summary>
    internal class Employee : Person
    {
        /// <summary>
        /// поле Название компании
        /// </summary>
        string company;

        /// <summary>
        /// поле Долность сотрудника
        /// </summary>
        string job;

        /// <summary>
        /// свойство Название компании
        /// </summary>
        public string Company { get => company; set => company = value; }

        /// <summary>
        /// свойство Должность сотрудника
        /// </summary>
        public string Job { get => job; set => job = value; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Employee() { }

        /// <summary>
        /// Конструктор с пятью параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="company">Название компании</param>
        /// <param name="job">Должность сотрудника</param>
        public Employee(string name, string surname, int age, string company, string job) : base(name, surname, age)
        {
            Company = company;
            Job = job;
        }

        new public void Output()
        {
            Console.WriteLine($"{base.ToString()}Компания: {Company,-15}Должность: {Job,-10}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}Компания: {Company,-15}Должность: {Job,-10}";
        }
    }
}
