using System;
using System.Collections.Generic;
using System.Text;

namespace Athletes
{
    class SoccerPlayer : Athlete
    {
        public override void Exercise()
        {
            Console.WriteLine("Run 4 miles\nPractice Dribbling and Passing\nTake Shots on Goal");
        }

        public override void Play()
        {
            Console.WriteLine("Sprint back and forth on field. Pass the ball. Take shots on goal!");
        }
    }
}
