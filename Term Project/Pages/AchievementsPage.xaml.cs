using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

// Author: Hira Ahmad
public partial class AchievementsPage : ContentPage
{
	public AchievementsPage(User user)
	{
		InitializeComponent();
        List<Achievement> achievements = GetAchievements();
        AchievementsListView.ItemsSource = achievements;
    }

    private List<Achievement> GetAchievements()
    {
        var achievements = new List<Achievement>();
        Achievement stepsAchievement = new Achievement("10k Steps", "Completed 10,000 steps", "user_icon.png", false);
        Achievement waterAchievement = new Achievement("2L Water", "Drank 2 Litres of water", "user_icon.png", false);
        Achievement sleepAchievement = new Achievement("8H Sleep", "Slept for 8 hours", "user_icon.png", false);

        int totalSteps = getTotalSteps();
        double toatlWaterIntake = getTotalWaterIntakeForToday();
        double totalSleep = getTotalSleepForToday();

        if (totalSteps >= 10000)
        {
            stepsAchievement.IsAchieved = true;
            DisplayAlert("Congratulations!", "You have achieved your goal for today!", "Ok");
        }
        achievements.Add(stepsAchievement);

        if (toatlWaterIntake >= 2)
        {
            waterAchievement.IsAchieved = true;
            DisplayAlert("Congratulations!", "You have achieved your goal for today!", "Ok");
        }
        achievements.Add(waterAchievement);

        if (totalSleep >= 8)
        {
            sleepAchievement.IsAchieved = true;
            DisplayAlert("Congratulations!", "You have achieved your goal for today!", "Ok");
        }
        achievements.Add(sleepAchievement);

        return achievements;
    }

    private int getTotalSteps()
    {
        int totalSteps = 0;
        foreach (Activity activity in App.UserActivityList)
        {
            totalSteps = totalSteps + activity.Steps;
        }

        return totalSteps;
    }

    private double getTotalWaterIntakeForToday()
    {
        var healthDataForToday = App.UserHealthList.FindAll(health => health.Date == DateTime.Today);
        double toatlWaterIntake = 0;
        foreach (Health health in healthDataForToday)
        {
            toatlWaterIntake = toatlWaterIntake + health.WaterIntake;
        }

        return toatlWaterIntake;
    }

    private double getTotalSleepForToday()
    {
        var healthDataForToday = App.UserHealthList.Find(health => health.Date == DateTime.Today);
        double totalSleep = 0;
        foreach (Health health in App.UserHealthList)
        {
            totalSleep = totalSleep + health.Sleep;
        }

        return totalSleep;
    }

    private void BackBtnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}