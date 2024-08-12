using Term_Project.BusinessLogic;

namespace Term_Project.Pages;

// Author: Hira Ahmad
public partial class AchievementsPage : ContentPage
{
	public AchievementsPage(User user)
	{
		InitializeComponent();
        List<Achievement> achievements = GetAchievements(user);
        AchievementsListView.ItemsSource = achievements;
    }

    private List<Achievement> GetAchievements(User user)
    {
        var achievements = new List<Achievement>();
        Achievement stepsAchievement = new Achievement("10k Steps", "Completed 10,000 steps", "footsteps.png", false);
        Achievement waterAchievement = new Achievement("2L Water", "Drank 2 Litres of water", "drop.png", false);
        Achievement sleepAchievement = new Achievement("8H Sleep", "Slept for 8 hours", "sleep.png", false);

        int totalSteps = getTotalStepsForToday(user);
        double toatlWaterIntake = getTotalWaterIntakeForToday(user);
        double totalSleep = getTotalSleepForToday(user);

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

    private int getTotalStepsForToday(User user)
    {
        var activityDataForToday = user.Activities.FindAll(activity => activity.Date == DateTime.Today);
        int totalSteps = 0;
        foreach (Activity activity in activityDataForToday)
        {
            totalSteps = totalSteps + activity.Steps;
        }

        return totalSteps;
    }

    private double getTotalWaterIntakeForToday(User user)
    {
        var healthDataForToday = user.Health.FindAll(health => health.Date == DateTime.Today);
        double toatlWaterIntake = 0;
        foreach (Health health in healthDataForToday)
        {
            toatlWaterIntake = toatlWaterIntake + health.WaterIntake;
        }

        return toatlWaterIntake;
    }

    private double getTotalSleepForToday(User user)
    {
        var healthDataForToday = user.Health.FindAll(health => health.Date == DateTime.Today);
        double totalSleep = 0;
        foreach (Health health in healthDataForToday)
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