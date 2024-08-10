using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

public partial class UserLoginPage : ContentPage
{
	public UserLoginPage()
	{
		InitializeComponent();
		AddBuiltInUser();

    }

	public void LoginBtnClicked(object sender, EventArgs e)
	{
		var usernameEntered = usernameEntry.Text;
		var passwordEntered = passwordEntry.Text;
		var userEntered = App.UsersList.Find(user => user.Username == usernameEntered && user.Password == passwordEntered);
		if (userEntered != null)
		{
			App.loggedInUser = userEntered;
			Navigation.PushAsync(new MainMenuPage());
		}
		else
		{
			DisplayAlert("Invalid user info", "Enter a valid username/password", "OK");
		}
	}

	public void NewUserBtnClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new AddUserPage());
	}

	//user to make it easier to work on the code :D

	public void AddBuiltInUser()
	{
		var builtInUser = new User
		{
            Name = "nick",
            Age = 20,
            Gender = "Prefer not to say",
            Weight = 144,
            Height = 159,
            FitnessGoal = "Get steps in :D",
            Username = "nikoe",
            Password = "1234"
        };
        App.UsersList.Add(builtInUser);
    }
}

