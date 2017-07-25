using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Effects
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myLabel.Effects.Add(new LabelFontEffect());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await System.Threading.Tasks.Task.Delay(3000);
            myLabel.Effects.Clear();
        }
    }
}
