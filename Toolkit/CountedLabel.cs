using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Toolkit
{

    // The read-only bindable property
    // Suppose you’re working with an application in which it’s convenient to know the number of words in the text that is displayed by a Label element.
    // Perhaps you’d like to build that facility right into a class that derives from Label.Let’s call this new class CountedLabel.
    public class CountedLabel : Label
    {
        static readonly BindablePropertyKey WordCountKey =
            BindableProperty.CreateReadOnly("WordCount",            // propertyName
                                            typeof(int),            // returnType
                                            typeof(CountedLabel),   // declaringType
                                            0);                     // defaultValue

        public static readonly BindableProperty WordCountProperty = WordCountKey.BindableProperty;

        public CountedLabel()
        {
            // Set the WordCount property when the Text property changes.
            PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
            {
                if (args.PropertyName == "Text")
                {
                    if (String.IsNullOrEmpty(Text))
                    {
                        WordCount = 0;
                    }
                    else
                    {
                        WordCount = Text.Split(' ', '-', '\u2014').Length;
                    }
                }
            };
        }

        public int WordCount
        {
            private set { SetValue(WordCountKey, value); }
            get { return (int)GetValue(WordCountProperty); }
        }
    }
}
