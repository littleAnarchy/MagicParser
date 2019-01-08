using System;

namespace TestOOPApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();

            Console.WriteLine(Horse.HorseCount);

            Horse horse = new Horse("Антон");
            horse.Jump();
            Console.WriteLine(Horse.HorseCount);

            Horse defaultHorse = null;
            for (int i = 0; i < 2; i++)
            {
                defaultHorse = new Horse();
                defaultHorse.Jump();
                Console.WriteLine(Horse.HorseCount);
                GC.Collect();
            }

            horse.Jump();

            horse = null;

            defaultHorse?.Jump();

            GC.Collect();

            Console.Read();
        }
    }
}
