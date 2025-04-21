namespace Zadacha_za_ocenka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой служители: ");
            int n = int.Parse(Console.ReadLine());

            Employee[] employees = InfoPersonal(n);
            string[] departments = GetDepartments(employees);
            string bestDepartment = GetBestDepartment(employees, departments);
            Employee[] bestEmployees = GetEmployeesFromDepartment(employees, bestDepartment);
            SortEmployeesBySalaryDescending(bestEmployees);

            Console.WriteLine();
            Console.WriteLine("Отдел с най-висока средна заплата:");
            Console.WriteLine("Highest Average Salary: " + bestDepartment);
            PrintEmployees(bestEmployees);
        }

        static Employee[] InfoPersonal(int n)
        {
            Employee[] employees = new Employee[n];

            Console.WriteLine("Въведете име заплата длъжност отдел [ел. поща] [възраст]: ");
            
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("=======================================================");
                Console.Write($"Служител {i + 1}: ");
                string[] parts = Console.ReadLine().Split(' ');
                string name = parts[0];
                double salary = double.Parse(parts[1]);
                string position = parts[2];
                string department = parts[3];
                string email = "n/a";
                int age = -1;

                if (parts.Length == 5)
                {
                    if (parts[4].Contains("@")) email = parts[4];
                    else age = int.Parse(parts[4]);
                }
                else if (parts.Length == 6)
                {
                    email = parts[4];
                    age = int.Parse(parts[5]);
                }

                employees[i] = new Employee(name, salary, position, department, email, age);
            }

            return employees;
        }

        static string[] GetDepartments(Employee[] employees)
        {
            string[] departments = new string[employees.Length];
            int count = 0;

            for (int i = 0; i < employees.Length; i++)
            {
                string dep = employees[i].Department;
                bool exists = false;

                for (int j = 0; j < count; j++)
                {
                    if (departments[j] == dep)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    departments[count++] = dep;
                }
            }

            string[] result = new string[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = departments[i];
            }

            return result;
        }

        static string GetBestDepartment(Employee[] employees, string[] departments)
        {
            double maxAvg = 0;
            string bestDep = "";

            for (int i = 0; i < departments.Length; i++)
            {
                string dep = departments[i];
                double total = 0;
                int count = 0;

                for (int j = 0; j < employees.Length; j++)
                {
                    if (employees[j].Department == dep)
                    {
                        total += employees[j].Salary;
                        count++;
                    }
                }

                double avg = total / count;
                if (avg > maxAvg)
                {
                    maxAvg = avg;
                    bestDep = dep;
                }
            }

            return bestDep;
        }

        static Employee[] GetEmployeesFromDepartment(Employee[] employees, string department)
        {
            Employee[] temp = new Employee[employees.Length];
            int count = 0;

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Department == department)
                {
                    temp[count++] = employees[i];
                }
            }

            Employee[] result = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        static void SortEmployeesBySalaryDescending(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = 0; j < employees.Length - i - 1; j++)
                {
                    if (employees[j].Salary < employees[j + 1].Salary)
                    {
                        Employee temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintEmployees(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i].Name} {employees[i].Salary:F2} {employees[i].Email} {employees[i].Age}");
            }
        }
    }
}
