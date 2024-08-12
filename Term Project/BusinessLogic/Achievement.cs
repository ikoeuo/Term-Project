using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project.BusinessLogic
{
    public class Achievement
    {
        private string _name;
        private string _description;
        private string _icon;
        private string _isAchieved;

        // Constructor
        public Achievement(string name, string description, string icon, bool isAchieved)
        {
            Name = name;
            Description = description;
            Icon = icon;
            IsAchieved = isAchieved;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }

        public bool IsAchieved { get; set; } // Determines if the achievement is unlocked
    }
}
