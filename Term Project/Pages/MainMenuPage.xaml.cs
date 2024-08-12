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

    private void addHealthBtnClicked(object sender, EventArgs e)
    {
        var loggedInUser = App.loggedInUser;
        Navigation.PushAsync(new AddHealthPage(loggedInUser));
    }

    private void viewHealthBtnClicked(object sender, EventArgs e)
    {
        var loggedInUser = App.loggedInUser;
        Navigation.PushAsync(new ViewHealthPage(loggedInUser));
    }

    private void viewActivityBtnClicked(object sender, EventArgs e)
    {
        var loggedInUser = App.loggedInUser;
        Navigation.PushAsync(new ViewActivityPage(loggedInUser));
    }
}