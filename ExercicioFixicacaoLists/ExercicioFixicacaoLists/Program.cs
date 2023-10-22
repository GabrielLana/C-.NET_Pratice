
using ExercicioFixicacaoLists;
using System.Globalization;

namespace Course
{
    public class Course
    {
        public static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? "); int maxEmployee = int.Parse(Console.ReadLine());
            while (maxEmployee <= 0)
            {
                Console.WriteLine("Por favor insira um valor válido.");
                Console.Write("How many employees will be registered? "); maxEmployee = int.Parse(Console.ReadLine());
            }

            IList<Employee> employeeList = new List<Employee>();

            byte i = 1;
            while (i <= maxEmployee)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: "); int id = int.Parse(Console.ReadLine());
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Salary: R$"); double salary = double.Parse(Console.ReadLine());
                employeeList.Add(new Employee(id, name, salary));
                i++;
            }

            Console.Write("Enter the employee ID that will have salary increase: "); int employeeId = int.Parse(Console.ReadLine());
            if (employeeList.Select(el => el.Id).Contains(employeeId))
            {
                Console.Write("Enter the percentage: "); double percentage = double.Parse(Console.ReadLine());
                employeeList.Where(el => el.Id == employeeId).First().RaiseSalary(percentage);
            }

            Console.WriteLine("Updated list of employees:");
            foreach (var item in employeeList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}