using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica5.ViewModel;

namespace Practica5.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RNCView : ContentPage
    {
        public RNCView()
        {
            InitializeComponent();
            BindingContext = new RNCViewModel();
        }
    }
}