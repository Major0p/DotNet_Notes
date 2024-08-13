//shubham

using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace core_Web_App.Classes
{
    public class LINQ
    {
        public void main()
        {
            List<int> data = new List<int>();

            int i = 0;
            do
            {
                data.Add(i++);
            }
            while (i <= 10);

            //method syntax
            // you dont need to mention column name when using in memory collection 
            var res = data.Where(item => item > 5);

            // when you are using database query then ist is good to mention column name 
            //var ress = dbcontext.tableName.where(item=>item.columnName > 5);

            //query syntax
            var qres = from item in res where item > 5 select item;


            var mm = from item in res where item % 2 == 0 select item;
            var lkjj = res.Where(item => item % 2 == 0);


            //---------------------------------------------------------------------------------------------------------------------------------------------------
            // Group and Aggregation 

            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 2, 5, 1 };
            List<string> charList = new List<string> { "Apple", "Banana", "Mango", "Orange", "Graps", "Banana", "Orange" };

            //to get same length string and there count 
            var ans1 = charList
                .GroupBy(item => item.Length)
                .Select(grp => new { length = grp, count = grp.Count() });

            var ans4 = from item in numberList
                       group item by item > 4 into grp
                       select new { a = grp, b = grp };

            //get frequency and number
            var ans2 = from item in numberList
                       where item < 5
                       select item;

            var ans3 = from item in numberList
                       where item % 2 == 0
                       where item > 0
                       select item;

            //sum of all salaries
            var employees = new[]{
                new { Name = "John", Salary = 50000 },
                new { Name = "Jane", Salary = 60000 },
                new { Name = "Tom", Salary = 55000 },
                new { Name = "Emily", Salary = 52000 }
            };

            var ans5 = (from sal in employees
                        select sal.Salary).Sum();

            var ans6 = (from sal in employees
                        select sal.Salary).Max();

            var ans7 = employees.Average(sal => sal.Salary);

            var ans8 = employees.Where(sal => sal.Salary > 52000).Sum(sal => sal.Salary);

            var ans9 = (from sal in employees
                        where sal.Salary > 52000
                        select sal.Salary).Sum();

            //--------------------------------------------------------------------------------------------------------------------------------------------------
            // Join

            var employee = new[]
            {
                new { EmployeeID = 1, Name = "John", DepartmentID = 1 },
                new { EmployeeID = 2, Name = "Jane", DepartmentID = 2 },
                new { EmployeeID = 3, Name = "Tom", DepartmentID = 1 }
            };

            var departments = new[]
            {
                new { DepartmentID = 1, DepartmentName = "HR" },
                new { DepartmentID = 2, DepartmentName = "IT" }
            };

            var Team = new[]
            {
                new { DeparmentId = 1, TeamId = 1 },
                new { DeparmentId = 2, TeamId = 2 },
                new { DeparmentId = 3, TeamId = 3 },
            };

            var innerJoinDep = employees.Join(
                departments,
                empl => empl.DepartmentID,
                dep => dep.DepartmentID
                (emp, dep) => new { name = emp.name, dept = dep.DepartmentName });

            var innnerJoinDepQ = from emp in employees
                                 join dep in departments on emp.DepartmentID equals dep.DepartmentID
                                 select new { name = emp.Name, department = dep.DepartmentName };

            var innerJoinT = departments.Join(Team, dep => dep.DepartmentID, tm => tm.DeparmentId, (dep, tm) => new { tmid = tm.TeamId, depid = dep.DepartmentID });

            var innerJoinTQ = from dep in departments
                              join tm in Team on dep.DepartmentID equals tm.DeparmentId
                              select new { tmid = tm.TeamId, depid = tm.DeparmentId };


            var leftJoin = employees.GroupJoin(
                departments,
                emp => emp.DepartmentID,
                dept => dept.DepartmentID,
                (emp, deptGroup) => new { emp.Name, Department = deptGroup.FirstOrDefault()?.DepartmentName }
            );

            // Query Syntax
            var leftJoinQuery = from emp in employees
                                join dept in departments on emp.DepartmentID equals dept.DepartmentID into empDept
                                from dept in empDept.DefaultIfEmpty()
                                select new { emp.Name, Department = dept?.DepartmentName };
        }
    }
}



