using System;
using System.Collections.Generic;
using System.Text;

namespace Athletes
{
    abstract class Athlete
    {
        public void ExecuteDayOfAthlete()
        {
            Exercise();
            Play();
            Eat();
            Sleep();
            Console.WriteLine();
        }

        // Exercise
        public abstract void Exercise();

        // Play
        public abstract void Play();

        // Eat
        private void Eat()
        {
            Console.WriteLine("Eat a few thousand calories to make up for todays hard work");
        }

        // Sleep
        private void Sleep()
        {
            Console.WriteLine("Pass out for 9 hours and get up at 5:30 AM");
        }
    }
}
