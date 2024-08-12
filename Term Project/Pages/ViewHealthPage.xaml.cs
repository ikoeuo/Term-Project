using Term_Project.BusinessLogic;

namespace Term_Project.Pages;
// Author: Hira Ahmad

public partial class ViewHealthPage : ContentPage
{
	public ViewHealthPage(User user)
	{
		InitializeComponent();
        HealthListView.ItemsSource = App.UserHealthList;
    }

    private void BackBtnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}