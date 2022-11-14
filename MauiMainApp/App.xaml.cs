using MauiMainApp.Pages;

namespace MauiMainApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppBootstrapper().Bootstrap().CreateMainPage();
	}
}
