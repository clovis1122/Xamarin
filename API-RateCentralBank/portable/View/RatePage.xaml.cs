using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RateCentralBankSample.ViewModels;

namespace RateCentralBankSample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatePage : ContentPage
    {
        public RatePage()
        {
            InitializeComponent();
            BindingContext = new RateViewModel();
        }
    }
}