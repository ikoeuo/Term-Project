using Term_Project.BusinessLogic;

namespace Term_Project
{
    public partial class App : Application
    {
        public static List<User> Users = new List<User>();
        public static User loggedInUser;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
