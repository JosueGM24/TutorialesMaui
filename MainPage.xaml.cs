
using TutorialesMaui.Pages;

namespace TutorialesMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        if (userEntry.Text.Equals("Dani"))
        {
            FlyoutPageT fly = new FlyoutPageT();
            await Navigation.PushAsync(fly);
        } else
        {
            await DisplayAlert("Not are you", "User or password incorrect", "Ok");
        }
    }

    private void SignUpBtn_Clicked(object sender, EventArgs e)
    {

    }
}

