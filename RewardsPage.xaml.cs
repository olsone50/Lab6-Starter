namespace Lab6_Starter;

public partial class RewardsPage : ContentPage
{
    public RewardsPage()
    {
        InitializeComponent();

    }

    public bool SubmitApplication()
    {
        //returns true if submited 
        return true;
    }

    public int NumberOfAirportsVisited()
    {
        //returns the number of airports visited
        return 0;
    }

    public string RewardStatus()
    {
        //returns either bronze, silver, gold, or null
        return null;
    }

    public void OnSubmitButtonClicked(object sender, EventArgs e)
    {
        // This button should work only if they have enough airports visited for a reward status to be met
    }
}


