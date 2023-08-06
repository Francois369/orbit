using OrbitSimulator.Application;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Planet Mercury = new Planet();
        Planet Venus = new Planet();
        Planet Earth = new Planet();
        Planet Mars = new Planet();
        Planet Jupiter = new Planet();
        Planet  Saturn = new Planet();
        Planet Uranus = new Planet();
        Planet Neptune = new Planet();

        Mercury.OrbitTimeInDays = 88;
        Venus.OrbitTimeInDays = 225;
        Earth.OrbitTimeInDays = 365;
        Mars.OrbitTimeInDays = 387;
        Jupiter.OrbitTimeInDays = 4333;
        Saturn.OrbitTimeInDays = 10759;
        Uranus.OrbitTimeInDays = 30687;
        Neptune.OrbitTimeInDays = 60190;
        int i = 1000;
        while (1 == 1)
        {
         
            if (Mercury.CurrentPositionInRelationToTime(i) == Venus.CurrentPositionInRelationToTime(i) &&
                Venus.CurrentPositionInRelationToTime(i) == Earth.CurrentPositionInRelationToTime(i) && 
                Earth.CurrentPositionInRelationToTime(i) == Mars.CurrentPositionInRelationToTime(i) &&
                Mars.CurrentPositionInRelationToTime(i) == Jupiter.CurrentPositionInRelationToTime(i) &&
                Jupiter.CurrentPositionInRelationToTime(i) == Saturn.CurrentPositionInRelationToTime(i) &&
                Saturn.CurrentPositionInRelationToTime(i) == Uranus.CurrentPositionInRelationToTime(i) &&
                Uranus.CurrentPositionInRelationToTime(i) == Neptune.CurrentPositionInRelationToTime(i))
            {
                Console.WriteLine("Based on current definition of alignment within 36 degrees it will take:");  
                Console.WriteLine((i / 24).ToString() + " Days or");
                Console.WriteLine((i / 8640).ToString() + " Years");
                Console.WriteLine("For the planets to  be reunited in alignement from a starting point of alignment");
                break;
            }
            else {  i++; };
        }


    }
}