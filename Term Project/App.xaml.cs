using Term_Project.BusinessLogic;
using Term_Project.DataLayer;
using Term_Project.Pages;

namespace Term_Project
// Author: Nikole Phipps Santos
{
    public partial class App : Application
    {
        public static List<User> UsersList;
        public static User? loggedInUser;
        public static string usersFilename = "users.json";
        public App()
        {
            InitializeComponent();
            UsersList = Repository.ReadUserDataFromJsonFile(usersFilename);
            MainPage = new NavigationPage(new UserLoginPage());
        }
    }
}
