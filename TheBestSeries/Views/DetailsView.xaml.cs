using System;
using System.Collections.Generic;
using TheBestSeries.Models;
using Xamarin.Forms;

namespace TheBestSeries.Views
{
    public partial class DetailsView : ContentPage
    {
        public Series Filme { get; set; }
        bool subtitle;
        public bool Subtitles
        {
            get
            {
                return subtitle;
            }
            set {
             
                subtitle = value;

                if (subtitle)
                    DisplayAlert("Legenda", "Ligado", "OK");
                else
                    DisplayAlert("Legenda", "Desligado", "OK");
            }
        }

        public DetailsView(Series filme)
        {
            InitializeComponent();
            this.Filme = filme;
            this.BindingContext = this;
        }
    }
}
