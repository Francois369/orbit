using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrbitSimulator.Application
{
    internal class Planet : IPlanet
    {
        public int OrbitTimeInDays { get; set; }
    
        public int PositionInrelationToTime { get; set; }

        private int positionInrelationToTime(int hoursElapsed)
        {
            decimal orbitTimeinHours = OrbitTimeInDays * 24;
            decimal currentCycleHours = hoursElapsed % orbitTimeinHours;
            decimal currentPositionFraction = currentCycleHours / orbitTimeinHours;
            decimal currentDegrees = currentPositionFraction * 10;
            int  result = (int)System.Math.Floor(currentDegrees);
    
            return result;
        }
        public int CurrentPositionInRelationToTime(int hoursElapsed)
        {
            return positionInrelationToTime(hoursElapsed);
        }
    }
}
