namespace TeenFeel.Controls
{
    public class CircularProgressBarDrawable : IDrawable
    {
        public int Progress { get; set; }
        public Color StrokeColor { get; set; }
        public Color ProgressColor { get; set; }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if (Progress < 0)
            {
                Progress = 0;
            }
            else if (Progress > 100)
            {
                Progress = 100;
            }

            if (Progress < 100)
            {
                float angle = GetAngle(Progress);

                canvas.StrokeColor = StrokeColor;
                canvas.StrokeSize = 2;
                canvas.DrawEllipse(0,0,dirtyRect.Width, dirtyRect.Height);

                // Draw Arc
                canvas.StrokeColor = ProgressColor;
                canvas.StrokeSize = 3;
                canvas.DrawArc(0, 0, dirtyRect.Width, dirtyRect.Height, 90, angle, true, false);
            }
            else
            {
                // Draw Circle
                canvas.StrokeColor = ProgressColor;
                canvas.StrokeSize = 2;
                canvas.DrawEllipse(0, 0, dirtyRect.Width, dirtyRect.Height);
            }
        }
        
        float GetAngle(int progress)
        {
            float factor = 90f / 25f;

            if (progress > 75)
                return -180 - ((progress - 75) * factor);
            else if (progress > 50)
                return -90 - ((progress - 50) * factor);
            else if (progress > 25)
                return 0 - ((progress - 25) * factor);
            else
                return 90 - (progress * factor);
        }
    }
}