using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

public partial class AchivementsPage : ContentPage
{
	public AchivementsPage(User user)
	{
		InitializeComponent();
        AchievementsListView.ItemsSource = App.AchievementList;
    }

    private void BackBtnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}