using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = InputStudents(3);

            List<Employee> employees = InputEmployees(3);

            Console.Write("Вывести студентов (s) или работников (e)? ");
            char c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case 'S':
                case 's':
                    OutputStudentArray(students);
                    break;
                case 'E':
                case 'e':
                    OutputEmployeeList(employees);
                    break;
            }

            Console.ReadKey(true);
        }

        static Student[] InputStudents(int length)
        {
            Student[] students = new Student[length];
            for(int i = 0; i < length; i++)
            {
                Console.Write($"Имя {i + 1}-го студента: ");
                string name = Console.ReadLine();
                Console.Write($"Фамилия {i + 1}-го студента: ");
                string surname = Console.ReadLine();
                Console.Write($"Возраст {i + 1}-го студента: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write($"Дата рождения {i + 1}-го студента: ");
                DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.Write($"Курс {i + 1}-го студента: ");
                string course = Console.ReadLine();
                students[i] = new Student(name, surname, age, dateOfBirth, course);
            }
            return students;
        }

        static void OutputStudentArray(Student[] array)
        {
            Console.WriteLine("Список: ");
            foreach(Student student in array)
            {
                Console.WriteLine($"  {student}");
            }
        }

        static List<Employee> InputEmployees(int length)
        {
            List<Employee> employees = new List<Employee> ();
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Имя {i + 1}-го работника: ");
                string name = Console.ReadLine();
                Console.Write($"Фамилия {i + 1}-го работника: ");
                string surname = Console.ReadLine();
                Console.Write($"Возраст {i + 1}-го работника: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write($"Название предприятия {i + 1}-го работника: ");
                string company = Console.ReadLine();
                Console.Write($"Должность {i + 1}-го работника: ");
                string job = Console.ReadLine();
                employees.Add(new Employee(name, surname, age, company, job));
            }
            return employees;
        }

        static void OutputEmployeeList(List<Employee> array)
        {
            Console.WriteLine("Список: ");
            foreach (Employee employee in array)
            {
                Console.WriteLine($"  {employee}");
            }
        }
    }
}
