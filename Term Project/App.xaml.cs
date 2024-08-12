using Term_Project.BusinessLogic;
using Term_Project.Pages;

namespace Term_Project
{
    public partial class App : Application
    {
        public static List<User> UsersList = new List<User>();
        public static List<Activity> UserActivityList = new List<Activity>();
        public static List<Health> UserHealthList = new List<Health>();
        public static List<Achievement> AchievementList = new List<Achievement>();
        public static User? loggedInUser;
        public App()
        {
            InitializeComponent();

            UsersList.Add(new User("a",1,"m",1,1,"","a","a","",""));

            Achievement steps = new Achievement("10k Steps", "Completed 10,000 steps", "user_icon.png", false);
            Achievement water = new Achievement("2L Water", "Drank 2 Litres of water", "user_icon.png", false);
            Achievement sleep = new Achievement("8H Sleep", "Slept for 8 hours", "user_icon.png", false);
            AchievementList.Add(steps);
            AchievementList.Add(water);
            AchievementList.Add(sleep);

            MainPage = new NavigationPage(new UserLoginPage());
        }
    }
}
