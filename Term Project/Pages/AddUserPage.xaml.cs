using System.Collections.ObjectModel;
using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

//Author: Nikole Phipps Santos
public partial class AddUserPage : ContentPage
{
	public User user;
	public List<string> GenderList {  get; set; }
	public AddUserPage()
	{
		InitializeComponent();
		GenderList = new List<string> { "Male", "Female", "Non-Binary", "Prefer not to say" };
		BindingContext = this;
	}
	public void BackBtnClicked(object sender, EventArgs e)
	{
        Navigation.PopAsync();;
	}

	public void AddUserBtnClicked(object sender, EventArgs e)
	{
		if ( string.IsNullOrWhiteSpace(nameEntry.Text) || 
			genderEntry.SelectedItem == null || 
		    string.IsNullOrWhiteSpace(fitnessGoalEntry.Text) || 
			string.IsNullOrWhiteSpace(usernameEntry.Text) || 
			string.IsNullOrWhiteSpace(passwordEntry.Text) )
		{
			DisplayAlert("Field Empty", "Please fill in all user information", "OK");
			return;
		}
		if (!int.TryParse(ageEntry.Text, out _) || !float.TryParse(weightEntry.Text, out _) || !float.TryParse(heightEntry.Text, out _) )
		{
			DisplayAlert("Inavalid Selection", "Please enter valid numbers for Age/Weight/Height", "OK");
		}
		else {
			var newUser = new User
			{
				Name = nameEntry.Text,
				Age = int.Parse(ageEntry.Text),
				Gender = genderEntry.SelectedItem.ToString(),
				Weight = float.Parse(weightEntry.Text),
				Height = float.Parse(heightEntry.Text),
				FitnessGoal = fitnessGoalEntry.Text,
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};
			App.UsersList.Add(newUser);
			App.loggedInUser = newUser;
			Navigation.PushAsync(new MainMenuPage());

		}
	}
	
}