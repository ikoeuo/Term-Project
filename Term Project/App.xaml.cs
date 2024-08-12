using Term_Project.BusinessLogic;
using Term_Project.Pages;

namespace Term_Project
// Author: Nikole Phipps Santos
{
    public partial class App : Application
    {
        public static List<User> UsersList = new List<User>();
        public static User? loggedInUser;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new UserLoginPage());
        }
    }
}
