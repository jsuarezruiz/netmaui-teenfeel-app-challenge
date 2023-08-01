using TeenFeel.Models;

namespace TeenFeel.Services
{
    public class EmotionService
    {
        public IEnumerable<Emotion> GetEmotions()
        {
            return new List<Emotion>
            {
                new Emotion { Icon = "emotion01.png" },
                new Emotion { Icon = "emotion01.png" },
                new Emotion { Icon = "emotion01.png" },
                new Emotion { Icon = "emotion01.png" },
                new Emotion { Icon = "emotion01.png" },
                new Emotion { Icon = "emotion01.png" },
            };
        }
    }
}
