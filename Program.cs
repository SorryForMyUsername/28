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
            Person person = new Person("Илья", "Шичкин", 18);
            person.Output();
            Console.WriteLine($"{person}\n");

            Employee employee = new Employee("Иван", "Петров", 28, "Тиротекс", "менеджер");
            employee.Output();
            Console.WriteLine($"{employee}\n");

            Person third = new Employee("Андрей", "Иванов", 42, "Хайтек", "Директор");
            third.Output();
            Console.WriteLine($"{third}\n");

            Console.ReadKey(true);
        }
    }
}
