using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

public partial class ViewUserPage : ContentPage
{
	public ViewUserPage(User user)
	{
		InitializeComponent();
        usernameLabel.Text = $"Username: {user.Username}";
        nameLabel.Text = $"Name: {user.Name}";
        ageLabel.Text = $"Age: {user.Age}";
        genderLabel.Text = $"Gender: {user.Gender}";
        weightLabel.Text = $"Weight: {user.Weight}lb";
        heightLabel.Text = $"Height: {user.Height}cm";
        fitnessGoalLabel.Text  = $"Fitness Goal: {user.FitnessGoal}";

    }

    public void BackBtnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    public void logoutBtnClicked(object sender, EventArgs e)
    {
        App.loggedInUser = null; 
        Navigation.PushAsync(new UserLoginPage());
    }

}