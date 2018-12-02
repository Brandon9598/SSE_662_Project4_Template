using System;

namespace Athletes
{
    class Program
    {
        static void Main(string[] args)
        {
            Golfer golfer = new Golfer();
            SoccerPlayer soccerPlayer = new SoccerPlayer();

            golfer.ExecuteDayOfAthlete();
            soccerPlayer.ExecuteDayOfAthlete();

            Console.Read();
        }
    }
}
