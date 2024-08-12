using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

// Author: Hira Ahmad

public partial class AddActivityPage : ContentPage
{
    User user;

    public AddActivityPage(User user)
    {
        InitializeComponent();

        this.user = user;
    }

    private void BackBtnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void AddActivityBtnClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(activityTypeEntry.Text) ||
            string.IsNullOrWhiteSpace(durationEntry.Text) ||
            string.IsNullOrWhiteSpace(distanceEntry.Text) ||
            string.IsNullOrWhiteSpace(stepsEntry.Text))
        {
            DisplayAlert("Field Empty", "Please fill in all health information", "OK");
            return;
        }
        if (!int.TryParse(durationEntry.Text, out _) || !float.TryParse(distanceEntry.Text, out _) || !int.TryParse(stepsEntry.Text, out _))
        {
            DisplayAlert("Invalid Selection", "Please enter valid numbers for Calories/Sleep/Water Intake", "OK");
        }
        else
        {
            var newActivity = new Activity(activityDatePicker.Date, activityTypeEntry.Text, int.Parse(durationEntry.Text), float.Parse(distanceEntry.Text), int.Parse(stepsEntry.Text));
            this.user.Activities.Add(newActivity);
            Navigation.PushAsync(new MainMenuPage());

        }
    }
}