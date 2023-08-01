namespace TeenFeel.Controls
{
    public class CircularProgressBar : GraphicsView
    {
        public CircularProgressBar()
        {
            Drawable = ProgressRadialDrawable = new CircularProgressBarDrawable();
        }

        CircularProgressBarDrawable ProgressRadialDrawable { get; set; }

        public static readonly BindableProperty ProgressProperty =
            BindableProperty.Create(nameof(Progress), typeof(int), typeof(CircularProgressBar),
                propertyChanged: (bindableObject, oldValue, newValue) =>
                {
                    if (newValue != null && bindableObject is CircularProgressBar circularProgressBar)
                    {
                        circularProgressBar.UpdateProgress();
                    }
                });

        public static readonly BindableProperty ProgressColorProperty =
            BindableProperty.Create(nameof(ProgressColor), typeof(Color), typeof(CircularProgressBar),
                propertyChanged: (bindableObject, oldValue, newValue) =>
                {
                    if (newValue != null && bindableObject is CircularProgressBar circularProgressBar)
                    {
                        circularProgressBar.UpdateProgressColor();
                    }
                });

        public static readonly BindableProperty StrokeColorProperty =
            BindableProperty.Create(nameof(StrokeColor), typeof(Color), typeof(CircularProgressBar),
                propertyChanged: (bindableObject, oldValue, newValue) =>
                {
                    if (newValue != null && bindableObject is CircularProgressBar circularProgressBar)
                    {
                        circularProgressBar.UpdateStrokeColor();
                    }
                });

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CircularProgressBar),
                propertyChanged: (bindableObject, oldValue, newValue) =>
                {
                    if (newValue != null && bindableObject is CircularProgressBar circularProgressBar)
                    {
                        circularProgressBar.UpdateStrokeColor();
                    }
                });

        public int Progress
        {
            get => (int)GetValue(ProgressProperty);
            set => SetValue(ProgressProperty, value);
        }

        public Color ProgressColor
        {
            get { return (Color)GetValue(ProgressColorProperty); }
            set { SetValue(ProgressColorProperty, value); }
        }

        public Color StrokeColor
        {
            get { return (Color)GetValue(StrokeColorProperty); }
            set { SetValue(StrokeColorProperty, value); }
        }

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        protected override void OnParentChanged()
        {
            base.OnParentChanged();

            if (Parent != null)
            {
                UpdateProgress();
                UpdateStrokeColor();
                UpdateProgressColor();
            }
        }

        void UpdateProgress()
        {
            if (ProgressRadialDrawable == null)
                return;

            ProgressRadialDrawable.Progress = Progress;
            Invalidate();
        }

        void UpdateStrokeColor()
        {
            if (ProgressRadialDrawable == null)
                return;

            ProgressRadialDrawable.StrokeColor = StrokeColor;
            Invalidate();
        }

        void UpdateProgressColor()
        {
            if (ProgressRadialDrawable == null)
                return;

            ProgressRadialDrawable.ProgressColor = ProgressColor;
            Invalidate();
        }
    }
}