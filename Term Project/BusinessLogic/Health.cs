using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project.BusinessLogic
//Author: Nikole Phipps Santos
{
    public class Health
    {
        public Health(DateTime date, int calories, double sleep, double waterIntake)
        {
            Date = date;
            Calories = calories;
            Sleep = sleep;
            WaterIntake = waterIntake;
        }

        public DateTime Date { get; set; }
        public int Calories { get; set; }
        public double Sleep {  get; set; } //sleep in hours
        public double WaterIntake {  get; set; } // water intake in Litres

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}, Calories: {Calories}, Sleep: {Sleep} hours, Water Intake: {WaterIntake}L ";
        }
    }
}
