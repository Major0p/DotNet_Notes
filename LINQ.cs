using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace core_Web_App.Classes
{
    public class LINQ
    {
        public void main()
        {
            List<int> data = new List<int>();

            int i = 0;
            do {
                data.Add(i++);
            }
            while (i<=10);

            //method syntax
            // you dont need to mention column name when using in memory collection 
            var res = data.Where(item=> item > 5 );

            // when you are using database query then ist is good to mention column name 
            //var ress = dbcontext.tableName.where(item=>item.columnName > 5);

            //query syntax
            var qres = from item in res where item > 5 select item;


            var mm = from item in res where item % 2 == 0 select item;
            var lkjj = res.Where(item => item%2 == 0);


        }
    }
}

