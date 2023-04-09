using Course;
using System.Globalization;

namespace Aulas {
    class Aulas {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee found = employees.Find(x => employees[0].Id == searchId);

            Employee emp = employees.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.WriteLine("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
                Console.WriteLine("Updated list of employees:");
                foreach (Employee employee in employees) {
                    Console.WriteLine(employee);
                }
            }
            else {
                Console.WriteLine("Invalid ID!");
            }
        }
    }
}
