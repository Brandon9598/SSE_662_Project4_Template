using System;
using System.Collections.Generic;
using System.Text;

namespace Athletes
{
    class Golfer : Athlete
    {
        public override void Exercise()
        {
            Console.WriteLine("Do arm and back exercise\nRun a mile");
        }

        public override void Play()
        {
            Console.WriteLine("Walk from course to course. Aim to score as low as possible.");
        }
    }
}
