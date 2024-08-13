using Term_Project.BusinessLogic;
using Term_Project.DataLayer;

namespace Term_Project.Pages;

// Author: Hira Ahmad 

public partial class AddHealthPage : ContentPage
{
    User user;

	public AddHealthPage(User user)
	{
		InitializeComponent();

        this.user = user;
	}

    private void BackBtnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void AddHealthBtnClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(caloriesEntry.Text) ||
            string.IsNullOrWhiteSpace(sleepEntry.Text) ||
            string.IsNullOrWhiteSpace(waterIntakeEntry.Text))
        {
            DisplayAlert("Field Empty", "Please fill in all health information", "OK");
            return;
        }
        if (!int.TryParse(caloriesEntry.Text, out _) || !double.TryParse(sleepEntry.Text, out _) || !double.TryParse(waterIntakeEntry.Text, out _))
        {
            DisplayAlert("Invalid Selection", "Please enter valid numbers for Calories/Sleep/Water Intake", "OK");
        }
        else
        {
            var newHealth = new Health(healthDatePicker.Date, int.Parse(caloriesEntry.Text), double.Parse(sleepEntry.Text), double.Parse(waterIntakeEntry.Text));
            this.user.Health.Add(newHealth);
            Repository.SaveUserDatatoJsonFile(App.usersFilename, App.UsersList);
            Navigation.PushAsync(new MainMenuPage());
        }
    }
}