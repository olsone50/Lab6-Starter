using CommunityToolkit.Maui.Views;
using Lab6_Starter.Model;

namespace Lab6_Starter;

public partial class AddAirport_Popup : Popup
{
    public AddAirport_Popup()
    {
        InitializeComponent();
    }

    public void OnExitButtonClicked(object? sender, EventArgs e)
    {
        Close();
    }

    public void OnAddAirport_Clicked(object senderm, EventArgs e)
    {
        DateTime dateVisited;

        if (DateTime.TryParse(DateVisitedENT.Text, out dateVisited) == false)
        {
            Close();
        }
        else
        {
            AirportAdditionError result = MauiProgram.BusinessLogic.AddAirport(IdENT.Text, CityENT.Text, DateTime.Parse(DateVisitedENT.Text), int.Parse(RatingENT.Text));
            if (result != AirportAdditionError.NoError)
            {
                Close();
            }
        }
    }
}