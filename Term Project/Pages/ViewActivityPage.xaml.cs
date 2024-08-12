using Term_Project.BusinessLogic;

namespace Term_Project.Pages;
///Author: Hira Ahmad

public partial class ViewActivityPage : ContentPage
{
	public ViewActivityPage(User user)
	{
		InitializeComponent();
        ActivityListView.ItemsSource = user.Activities;
    }

    private void BackBtnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}