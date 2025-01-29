using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class LInqClass
    {
        public void Main()
        {
            Basics basics = new Basics();
            basics.Main();
        }
    }

    public class Basics
    {
        public Data data = new();

        public void Main()
        {
            data.Main();
            //Select();
            //Where();
            //OrderBy();
            GroupBy();
        }

        public void Select()
        {
            var emply = from emp in data.employees select emp;
            Console.WriteLine("select all from table",emply);
            foreach (var e in emply)
            {
                Console.WriteLine($"id={e.Id}, name={e.Name}, city={e.City}, country={e.Country}, state={e.State}, salary={e.Salary}");
                Console.WriteLine("----------");
            }

            Console.WriteLine("------------------------------------------------------------");

            var emplySalary = from emp in data.employees select emp.Salary;
            Console.WriteLine("select one column from table", emplySalary);
            foreach (var e in emplySalary)
            {
                Console.WriteLine(e);
                Console.WriteLine("----------");
            }

            Console.WriteLine("------------------------------------------------------------");

            var emplySalary_Name_City = from emp in data.employees select new { salary = emp.Salary,name=emp.Name,city=emp.City};
            Console.WriteLine("select multiple column from table", emplySalary_Name_City);
            foreach (var e in emplySalary_Name_City)
            {
                Console.WriteLine(e.salary);
                Console.WriteLine(e.name);
                Console.WriteLine(e.city);
                Console.WriteLine("----------");
            }
        }

        public void Where()
        {
            //salary should be greater then 80000
            var emp = from e in data.employees where e.Salary > 80000 select e.Salary;
            foreach (var e in emp)
            {
                Console.WriteLine(e);
                Console.WriteLine("----------");
            }

            var emp1 = data.employees.Where(e => e.Salary > 5000).Select(e => e.Name);
            foreach (var e in emp1)
            {
                Console.WriteLine(e);
                Console.WriteLine("----------");
            }
        }

        public void OrderBy()
        {
            // salary order by accending
            var emp = from e in data.employees orderby e.Salary ascending select e.Name;
            foreach (var e in emp)
            {
                Console.WriteLine(e);
                Console.WriteLine("----------");
            }

            var emp1 = data.employees.OrderByDescending(e => e.Salary).Select(e => e.Name);
            foreach (var e in emp1)
            {
                Console.WriteLine(e);
                Console.WriteLine("----------");
            }
        }

        public void GroupBy()
        {
            var emp = from e in data.employees group e by e.Country into g select g;
            foreach (var e in emp)
            {
                Console.WriteLine(e);
                Console.WriteLine("----------");
            }
        }
    }

    public class Data
    {
        public List<Employee> employees = new List<Employee>();
        public List<Department> departments = new List<Department>();

        public void Main()
        {
            FillEmployees();
            FillDepartment();
        }

        public List<Department> FillDepartment()
        {
            departments.Add(new Department
            {
                Id = 1,
                DepartmentName = "IT",
                DepartmentHead = "Tim"
            });

            departments.Add(new Department
            {
                Id = 2,
                DepartmentName = "HR",
                DepartmentHead = "Kim"
            });

            departments.Add(new Department
            {
                Id = 3,
                DepartmentName = "Finance",
                DepartmentHead = "Adele"
            });

            departments.Add(new Department
            {
                Id = 4,
                DepartmentName = "Food",
                DepartmentHead = "Bella"
            });

            return departments;
        }

        public  List<Employee> FillEmployees()
        {
            employees.Add(new Employee
            {
                Id = 1,
                Name = "Robin",
                Phone = "919293",
                City = "alabama",
                Country = "USA",
                State = "alabama",
                Salary = 97500.6
            });

            employees.Add(new Employee
            {
                Id = 2,
                Name = "Ronie",
                Phone = "919267",
                City = "alabama",
                Country = "USA",
                State = "alabama",
                Salary = 67500.6
            });

            employees.Add(new Employee
            {
                Id = 3,
                Name = "Tom",
                Phone = "918993",
                City = "LA",
                Country = "USA",
                State = "LA",
                Salary = 100500.6
            });

            employees.Add(new Employee
            {
                Id = 4,
                Name = "Jonny",
                Phone = "6162",
                City = "Patna",
                Country = "India",
                State = "Bihar",
                Salary = 89500.6
            });

            employees.Add(new Employee
            {
                Id = 5,
                Name = "Joginder",
                Phone = "56273",
                City = "Haryana",
                Country = "India",
                State = "Haryana",
                Salary = 22500.6
            });

            employees.Add(new Employee
            {
                Id = 6,
                Name = "Chaman",
                Phone = "562347",
                City = "Burhanpur",
                Country = "India",
                State = "MP",
                Salary = 25500.6
            });

            return employees;
        }

        
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; } 
        public string State { get; set; }
        public double Salary { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentHead { get; set; }
    }

}
