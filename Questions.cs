using ConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Questions
    {
        Data data = new Data();
        public Questions() 
        {
            data.FillStudents();
        }

        public void Main()
        {
            Console.WriteLine( ReverseString("hello"));
            List<int> arr = new List<int>{ 1,2,3,4,3,5,6,2,3};
            Console.WriteLine(string.Join(",", FindDuplicates(arr)));
            Console.WriteLine(string.Join(",", EvenNum(arr)));
            Console.WriteLine(string.Join(",", StudentsScore()));
        }

        public string ReverseString(string str)
        {
            //string ans = string.Empty;
            //use string builder because concat iterate to the last and add
            StringBuilder sb = new StringBuilder();

            if(!string.IsNullOrEmpty(str) && str.Length > 0)
            {
                for(int i=str.Length-1;i>=0;i--)
                {
                    //ans += str[i];
                    sb.Append(str[i]);
                }
            }

            //return ans;
            return sb.ToString();
        }

        public List<int> FindDuplicates(List<int> numbers)
        {
            HashSet<int> unique = new HashSet<int>();
            HashSet<int> duplicate = new HashSet<int>();

            foreach (int num in numbers)
            {
                if(!unique.Add(num))
                    duplicate.Add(num);  
            }

            return duplicate.ToList<int>();
        }

        public List<int> EvenNum(List<int> list)
        {
            return list.Where(n => n % 2 == 0).OrderBy(n => n).ToList();
        }

        public void swapElmInArr(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public List<int> RemoveDuplicate(int[] arr)
        {
            List<int> res = new List<int>();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                    res.Add(arr[i]);
            }

            return res;
        }

        public List<int> MergeTwoSortedArr(int[] arr1, int[] arr2)
        {
            List<int> res = new List<int>();

            int len = Math.Max(arr1.Length, arr2.Length);

            return res;
        }

        public int GetSecondLargestNum(List<int> arr)
        {
            int res = 0;

            //using linq
            int[] ints = arr.OrderDescending().Take(2).ToArray();
            res = ints[1];

            //unique 
            res = arr.Distinct().OrderDescending().Skip(1).FirstOrDefault();

            return res;
        }

        public List<int> AllZeroToEnd(List<int> arr)
        {
            List<int> res = new List<int>();

            res = arr.OrderDescending().ToList<int>();

            return res;
        }

        //[1,2,4] = 124+1 = 125
        public int PlusOne(List<int> arr)
        {
            int res = 0;

            string arrStr = string.Join("", arr);
            res = int.Parse(arrStr) + 1;

            return res;
        }

        public List<List<int>> ReverseArrayInGroup(List<int> nums)
        {
            List<List<int>> res = new List<List<int>>();

            return res;
        }

        //[0, -1, 2, -3, 1]
        //-3,-1,0,1,2
        public bool PairWithGvnSum(List<int> arr, int target)
        {
            int left = 0;
            int right = arr.Count - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];

                if (sum == target)
                    return true;

                if (sum < target)
                    left++;
                else
                    right--;
            }

            return false;
        }

        //Given a list of students, return the names of students who scored more than 60, sorted by score descending.
        public List<string> StudentsScore()
        {
            return data.students.Where(s => s.Score > 60).OrderByDescending(s=>s.Score).Select(s=>s.Name).ToList();
        }

        //Given a list of employees, group them by department and return the count of employees in each department.
        public void GroupEmpByDept()
        {
            data.employees = new List<Employee>
            {
                new Employee { Name = "Alice", Department = "IT" },
                new Employee { Name = "Bob", Department = "HR" },
                new Employee { Name = "Charlie", Department = "IT" },
                new Employee { Name = "David", Department = "Finance" },
                new Employee { Name = "Eve", Department = "HR" },
                new Employee { Name = "Frank", Department = "IT" }
            };

            data.employees.GroupBy(e => e.Department).Select(g=>new { dept = g.Key, count = g.Count() });
        }
    }


    public class Data
    {
        public List<Employee> employees = new List<Employee>();
        public List<Department> departments = new List<Department>();
        public List<Student> students = new List<Student>();


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

        public List<Employee> FillEmployees()
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

        public List<Student> FillStudents()
        {
            students.Add(new Student { Name = "Alice", Score = 85 });
            students.Add(new Student { Name = "Bob", Score = 42 });
            students.Add(new Student { Name = "Charlie", Score = 73 });
            students.Add(new Student { Name = "David", Score = 60 });
            students.Add(new Student { Name = "Eve", Score = 91 });

            return students;
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
        public string Department { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentHead { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}

