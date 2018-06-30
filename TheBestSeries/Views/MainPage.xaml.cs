using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestSeries.Models;
using Xamarin.Forms;

namespace TheBestSeries.Views
{



    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            //listViewSeries.BindingContext = this;
        }


        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var filme = (Series)e.Item;
            Navigation.PushAsync(new DetailsView(filme));
        }
    }
}
