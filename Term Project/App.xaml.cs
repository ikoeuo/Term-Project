using Term_Project.BusinessLogic;
using Term_Project.Pages;

namespace Term_Project
{
    public partial class App : Application
    {
        public static List<User> UsersList = new List<User>();
        public static List<Activity> UserActivityList = new List<Activity>();
        public static List<Health> UserHealthList = new List<Health>();
        public static User? loggedInUser;
        public App()
        {
            InitializeComponent();

            UsersList.Add(new User("a",1,"m",1,1,"","a","a","",""));

            MainPage = new NavigationPage(new UserLoginPage());
        }
    }
}
