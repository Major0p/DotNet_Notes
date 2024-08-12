//shubham
namespace core_Web_App.Classes
{
    public abstract class AbsCls
    {
        public abstract void MakeSound();

        public string Def()
        {
            return "defination";
        }
    }

    public class Dog : AbsCls { 
        public override void MakeSound()
        {
            string sound = "Bhow";
        }
    }

    public class Cat : AbsCls {
        public override void MakeSound()
        {
            string sound = "Meow";
        }
    }

    public class Defination {

        public AbsCls cat = new Cat();
        
        public void work()
        {
            cat.Def();
        }
    }

}


