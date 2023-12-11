

namespace PersonalityQuizMauiApp
{
    public partial class MainPage : ContentPage
    {
        string[] questions = new string[]
        {
            "I face challenges head-on, without fear.",
            "I believe in the power of teamwork and collaboration.",
            "I often come up with innovative solutions to difficult problems.",
            "I strive to uphold justice, even if it's challenging.",
            "I always try to help and protect others, even at my own expense."
        };
        string[] results = new string[]
        {
            "The Fearless Leader: A commanding superhero leading others into battle.",
            "The Team Player: A superhero working seamlessly with a team, showcasing unity and cooperation.",
            "The Genius Inventor: A tech-savvy superhero surrounded by innovative gadgets and technology.",
            "The Justice Warrior: A superhero standing firm, embodying the spirit of justice and fairness.",
            "The Guardian Angel: A compassionate superhero shielding someone from harm, radiating kindness and protection."
        };

        string[] QuestionImages = new string[]
        {
            "couragehero.png",
            "teamworkheros.png",
            "innovation.png",
            "justice.png",
            "compassion.png"
        };
        int count = 0;
        int trues = -1;

        public MainPage()
        {
            InitializeComponent();
            UpdateQuestionAndImage();
        }

        private void OnClickedTrue(object sender, EventArgs e)
        {
            count++;
            trues++;
            UpdateQuestionAndImage();
        }

        private void OnClickedFalse(object sender, EventArgs e)
        {
            count++;
            UpdateQuestionAndImage();
        }

        private void UpdateQuestionAndImage()
        {
            if (count < questions.Length)
            {
                TheQuestion.Text = questions[count];
                TheImage.Source = QuestionImages[count];
            }else if (trues == -1)
            {
                TheQuestion.Text = "You Are No Hero You dont Deserve a Image";
                TheImage.IsVisible = false;
            }
            else
            {   
                TheQuestion.Text = results[trues] + (trues + 1);
                TheImage.Source = QuestionImages[trues];
                SwipeView.IsVisible = false;
            }
        }

    }
}