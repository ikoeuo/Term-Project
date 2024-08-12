using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

public partial class ViewActivityPage : ContentPage
{
	public ViewActivityPage(User user)
	{
		InitializeComponent();
        ActivityListView.ItemsSource = App.UserActivityList;
    }

    private void BackBtnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}