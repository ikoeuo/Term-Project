using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

public partial class MainMenuPage : ContentPage
{
	public User loggedInUser;
	public MainMenuPage()
	{
		InitializeComponent();
	}

	public void userBtnClicked(object sender, EventArgs e)
	{
		var loggedInUser = App.loggedInUser;
		Navigation.PushAsync(new ViewUserPage(loggedInUser));
	}
    public void addActivityBtnClicked(object sender, EventArgs e)
    {
        var loggedInUser = App.loggedInUser;
        Navigation.PushAsync(new AddActivityPage(loggedInUser));
    }
}