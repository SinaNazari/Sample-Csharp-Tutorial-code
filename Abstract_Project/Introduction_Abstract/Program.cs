using System;

namespace Introduction_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello hi = new SayHello();
            Console.WriteLine(hi.sayHello("Sina"));
            Console.ReadKey();
        }
    }

    
    public abstract class Hello
    {
        public virtual string sayHello(string name)
        {
            return "Hi";
        }
    }

    public class SayHello : Hello
    {
        public override string sayHello(string name)
        {
            return base.sayHello("Hello"+name);
        }
    }
}
