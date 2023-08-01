using System.Collections.ObjectModel;
using TeenFeel.Models;
using TeenFeel.Services;

namespace TeenFeel.Views;

public partial class HomeView : ContentPage
{
	public HomeView(EmotionService emotionService)
	{
		InitializeComponent();

		BindingContext = this;

        Emotions = new ObservableCollection<Emotion>(emotionService.GetEmotions());
    }

	public ObservableCollection<Emotion> Emotions { get; set; }
}