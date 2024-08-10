using Term_Project.BusinessLogic;
using Term_Project.Pages;

namespace Term_Project
{
    public partial class App : Application
    {
        public static List<User> UsersList = new List<User>();
        public static List<User> UserActivityList = new List<User>();
        public static List<User> UserHealthList = new List<User>();
        public static User? loggedInUser;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UserLoginPage()); ;
        }
    }
}
