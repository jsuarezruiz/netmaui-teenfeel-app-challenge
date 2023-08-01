namespace TeenFeel.Controls;

public partial class EmotionView : ContentView
{
	public EmotionView()
	{
		InitializeComponent();
    }

    public static readonly BindableProperty IconProperty = 
        BindableProperty.Create(nameof(Icon), typeof(ImageSource), typeof(EmotionView));
   
    public static readonly BindableProperty ColorProperty =
        BindableProperty.Create(nameof(Color), typeof(Color), typeof(EmotionView));

    public ImageSource Icon
    {
        get => (ImageSource)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public Color Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }
}