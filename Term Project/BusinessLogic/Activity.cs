using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project.BusinessLogic
//Author: Hira Ahmad

{
    public class Activity
    {
        public Activity(DateTime date, string activityType, int duration, float distance, int steps)
        {
            Date = date;
            ActivityType = activityType;             
            Duration = duration;
            Distance = distance;
            Steps = steps;
        }

        public DateTime Date { get; set; }

        public string ActivityType { get; set; }

        public int Duration { get; set; } //in mins 

        public float Distance { get; set; }  //in km 

        public int Steps { get; set; }

       
        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}, {ActivityType}, {Duration} mins, {Distance} km, {Steps}";
        }
    }
}
