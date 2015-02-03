namespace Animals
{
    using System;

    class Kitten : Cat
    {
        public Kitten(string name, int age)
            :base(name, age, "Male")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Purr...purr, purr");
        }
    }
}
