using Term_Project.BusinessLogic;
using Term_Project.Pages;

namespace Term_Project
// Author: Nikole Phipps Santos
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
            MainPage = new NavigationPage(new UserLoginPage());
        }
    }
}
