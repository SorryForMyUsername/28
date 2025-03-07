using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    /// <summary>
    /// Человек
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// поле Имя
        /// </summary>
        string name;

        /// <summary>
        /// поле Фамилия
        /// </summary>
        string surname;

        /// <summary>
        /// поле Возраст
        /// </summary>
        int age;

        /// <summary>
        /// свойство Имя
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// свойтсво Фамилия
        /// </summary>
        public string Surname { get => surname; set => surname = value; }

        /// <summary>
        /// свойтсов Возраст
        /// </summary>
        public int Age { get => age; set => age = value; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person() { }

        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public virtual void Output()
        {
            Console.WriteLine($"Имя: {Name,-10}Фамилия: {Surname,-10}Возраст: {Age,-5}");
        }

        /// <summary>
        /// Метод для вывода состояния объекта
        /// </summary>
        /// <returns>состояние объекта в виде строки</returns>
        public override string ToString()
        {
            return $"Имя: {Name,-10}Фамилия: {Surname,-10}Возраст: {Age,-5}";
        }
    }
}
