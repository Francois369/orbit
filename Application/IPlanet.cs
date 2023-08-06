using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitSimulator.Application
{
    interface  IPlanet 
    {
        
        public  int OrbitTimeInDays { get; set; }  
   
        public int PositionInrelationToTime { get; set; }


        public int CurrentPositionInRelationToTime(int hoursElapsed);
        

    }
}
