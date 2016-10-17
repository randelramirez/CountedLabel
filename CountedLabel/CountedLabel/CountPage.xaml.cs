using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
