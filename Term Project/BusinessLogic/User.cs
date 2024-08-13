using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project.BusinessLogic
//Author: Nikole Phipps Santos

{
    public class User
    {
        public User() 
        {
            Activities = new List<Activity>();
            Health = new List<Health>();
        }
        
        public User(string name, int age, string gender, float weight, float height, string fitnessGoal, string username, string password, string userActivity, string userHealth)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
            Height = height;
            FitnessGoal = fitnessGoal;
            Username = username;
            Password = password;
            Activities = new List<Activity>();
            Health = new List<Health>();
        }

        public string Name {  get; set; }
        public int Age { get; set; }
        public string Gender {  get; set; }
        public float Weight { get; set; }
        public float Height {  get; set; }
        public string FitnessGoal {  get; set; }
        public string Username {  get; set; }
        public string Password {  get; set; }

        public List<Activity> Activities { get; set; }

        public List<Health> Health { get; set; }
    }
}
