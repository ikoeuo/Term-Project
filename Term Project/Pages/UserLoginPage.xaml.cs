namespace Term_Project.Pages;

public partial class UserLoginPage : ContentPage
{
	public UserLoginPage()
	{
		InitializeComponent();
	}

	public void LoginBtnClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainMenuPage());
	}

	public void NewUserBtnClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new AddUserPage());
	}
}