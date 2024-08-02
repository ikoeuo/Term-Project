using System.Collections.ObjectModel;
using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

public partial class AddUserPage : ContentPage
{
	public AddUserPage()
	{
		InitializeComponent();
		BindingContext = new AddUserPageViewModel();

	}

	public class AddUserPageViewModel
	{
		public ObservableCollection<string> GenderList { get; set; }

		public AddUserPageViewModel()
		{
			GenderList = new ObservableCollection<string>
			{
				"Male", "Female", "Non-binary", "Prefer not to say"
			};

        }
	}

	public void BackBtnClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new UserLoginPage());
	}

	public void  AddUserBtnClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new MainMenuPage());
	}
	
}