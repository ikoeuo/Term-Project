using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project.BusinessLogic
{
    public class User
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public string Gender {  get; set; }
        public float Weight { get; set; }
        public float Height {  get; set; }
        public string FitnessGoal {  get; set; }
        public string Username {  get; set; }
        public string Password {  get; set; }

        public User(string name, int age, string gender, float weigth, float height, string fitnessGoal, string username, string password) 
        { 
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weigth;
            Height = height;
            FitnessGoal = fitnessGoal;
            Username = username;
            Password = password;
        }
    }
}
