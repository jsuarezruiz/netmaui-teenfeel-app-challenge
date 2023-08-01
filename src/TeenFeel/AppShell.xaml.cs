using TeenFeel.Views;

namespace TeenFeel;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent(); 
		
		Routing.RegisterRoute("home", typeof(HomeView));
    }
}
