//shubham 

namespace core_Web_App.Classes
{
    public class Vehichal  // base class
    {
        public string Model { get; set; }
        
        public DateTime GetTime()
        {
            return DateTime.Now;
        }

        public virtual void Price()
        {
            Console.WriteLine("price");
        }
    }

    //derived class 
    public class Swift : Vehichal  //inherit base class in derived class
    {
        public string name = "swift";

        //method overridding (RunTime polyMorphism) a method already define in base class it is redefine in derived class using virtual and override keyword
        public override void Price()
        {
            Console.WriteLine("9500000");
        }
    }

    //polyMorphism

    //method overloading (compile time polymorphism) it means same name method with diffrent parameter
    public class ComileTimePolyMorphism
    {
        public int add(int a, int b)
        {
            int ans = 0;
            ans = a + b;
            return ans;
        }

        public int add(int a, int b, int c)
        {
            int ans = 0;
            ans = a + b + c;
            return ans;
        }

        public double add(int a, double b)
        {
            double ans = 0;
            ans = a + b;
            return ans;
        }

        public float add(int a,float c)
        {
            float ans = 0;
            ans = a + c;
            return ans;
        }

    }



    public class Main
    {
        public void program()
        {
            Swift MyCar = new Swift();
            MyCar.Model = "zxi";
            MyCar.Price();
            string name = MyCar.name;
            DateTime RegTime = MyCar.GetTime();
        }
    }
}





