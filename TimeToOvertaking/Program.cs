using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToOvertaking
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mS = 0.28;    //izminato razstoqniq za 1s pri skorost 1km/h
            const double distanceForOneSecond = 1.67;  // izminato razstoqnie pri skorost 1km/h i vreme 6sec\za da izmine kola s dyljina 1 metyr razs 1metyr          
            const double timeToSelfOvertaking = 0;
            double timeToSelfOvertakingCar1 = 0;   
            double timeToSelfOvertakingCar2 = 0;
            double distanceToSelfOvertakingCar1 = 0;
            double distanceToSelfOvertakingCar2 = 0;

            Console.WriteLine("Please enter speed of car 1: ");
            bool parsedSpeedOfCar1 = double.TryParse(Console.ReadLine(), out double speedOfCar1);
            Console.WriteLine("Please enter speed of car 2: ");
            bool parsedSpeedOfCar2 = double.TryParse(Console.ReadLine(), out double speedOfCar2);
            Console.WriteLine("Please enter lenght of car 1: ");
            bool parsedLenghtOfCar1 = double.TryParse(Console.ReadLine(), out double lenghtOfCar1);
            Console.WriteLine("Please enter lenght of car 2: ");
            bool parsedLenghtOfCar2 = double.TryParse(Console.ReadLine(), out double lenghtOfCar2);

            speedOfCar1 *= mS;
            speedOfCar2 *= mS;
            timeToSelfOvertakingCar1 = lenghtOfCar1 / speedOfCar1;
            timeToSelfOvertakingCar2 = lenghtOfCar2 / speedOfCar2;
            //_______________________________________________________________________

            distanceToSelfOvertakingCar1 = speedOfCar1 * timeToSelfOvertakingCar1;
            distanceToSelfOvertakingCar2 = speedOfCar2 * timeToSelfOvertakingCar2;

            Console.WriteLine("timeToSelfOvertakingCar1: " + Math.Round(timeToSelfOvertakingCar1, 2) + "s");
            Console.WriteLine("distanceToSelfOvertakingCar1: " + Math.Round(distanceToSelfOvertakingCar1, 2) + "meters" + "\n");

            Console.WriteLine("timeToSelfOvertakingCar2: "+Math.Round(timeToSelfOvertakingCar2,2) + "s");
            Console.WriteLine("distanceToSelfOvertakingCar2: " +Math.Round(distanceToSelfOvertakingCar2,2) + "meters");



            // Console.WriteLine("Car 1 will overtake herself for " + Math.Round(timeToSelfOvertakingCar1,2) + "s");
            //Console.WriteLine("Car 1 will overtake herself for " + Math.Round(distanceToSelfOvertakingCar1,2) + " meters");

            //Console.WriteLine("Car 2 will overtake herself for " + Math.Round(timeToSelfOvertakingCar2,2) + "s");
            // Console.WriteLine("Car 2 will overtake herself for " + Math.Round(distanceToSelfOvertakingCar2, 2) + " meters");

            //Console.WriteLine("The distance for overtaking will be {0} meters",Math.Min(distanceToSelfOvertakingCar1,distanceToSelfOvertakingCar2));



            // Console.WriteLine("The car {0} will overtake car {1} for {2}s",Math.Max(speedOfCar1,speedOfCar2),Math.Min(speedOfCar1,speedOfCar2),);

        }
    }
}
