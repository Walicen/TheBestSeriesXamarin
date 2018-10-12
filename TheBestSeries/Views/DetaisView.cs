using System;

using Xamarin.Forms;

namespace TheBestSeries.Views
{
    public class DetaisView : ContentPage
    {
        public DetaisView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

