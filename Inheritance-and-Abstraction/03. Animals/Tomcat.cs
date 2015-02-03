namespace Animals
{
    using System;

    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            :base(name, age, "Male")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow...meow, meow");
        }
    }
}
