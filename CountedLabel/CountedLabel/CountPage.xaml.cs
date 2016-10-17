using Xamarin.Forms;

namespace CountedLabel
{
    public partial class CountPage : ContentPage
    {
        public CountPage()
        {
            InitializeComponent();
            int wordCount = countedLabel.WordCount;
            wordCountLabel.Text = wordCount + " words";
        }
    }
}
