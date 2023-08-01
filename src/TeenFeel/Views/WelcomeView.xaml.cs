namespace TeenFeel.Views;

public partial class WelcomeView : ContentPage
{
    IDispatcherTimer _timer;

	public WelcomeView()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing(); 
        
        _timer = Application.Current.Dispatcher.CreateTimer();
        _timer.Interval = TimeSpan.FromMilliseconds(50);
        _timer.Tick += (s, e) => DoSomething();
        _timer.Start();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        _timer?.Stop();
    }

    void DoSomething()
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            if (CircularProgress.Progress < 100)
                CircularProgress.Progress += 1;
            else
            {
                _timer?.Stop();
                await GoToHomeAsync();
            }
        });
    }

    async Task GoToHomeAsync()
    {
        await Shell.Current.GoToAsync("home");
    }

    async void OnNavigateTapped(object sender, TappedEventArgs e)
    {
        await GoToHomeAsync();
    }
}