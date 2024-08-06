namespace Term_Project.Pages;

public partial class UserLoginPage : ContentPage
{
	public UserLoginPage()
	{
		InitializeComponent();
	}

	public void LoginBtnClicked(object sender, EventArgs e)
	{
		var usernameEntered = usernameEntry.Text;
		var passwordEntered = passwordEntry.Text;
		var userEntered = App.Users.Find(user => user.Username == usernameEntered && user.Password == passwordEntered);
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
}