using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

// Author: Hira Ahmad 

public partial class AddHealthPage : ContentPage
{
	public AddHealthPage(User user)
	{
		InitializeComponent();
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
            DisplayAlert("Inavalid Selection", "Please enter valid numbers for Calories/Sleep/Water Intake", "OK");
        }
        else
        {
            var newHealth = new Health(healthDatePicker.Date, int.Parse(caloriesEntry.Text), double.Parse(sleepEntry.Text), double.Parse(waterIntakeEntry.Text));
            App.UserHealthList.Add(newHealth);
            Navigation.PushAsync(new MainMenuPage());
        }
    }
}