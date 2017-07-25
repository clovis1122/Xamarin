using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using System.ComponentModel;

namespace Practice6.ViewModels
{
    class MySimpleSamplePageViewModel : INavigatedAware, INotifyPropertyChanged
    {
        public string MyTitle { get; set; }
        public MySimpleSamplePageViewModel()
        {
            // En paginas es lo mismo, en el code behind se utiliza INavigationAware
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Para donde tu vas??
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            // VOY PA OTRO LADO (bueno, me fui)
        }
        
        public void OnNavigatedTo(NavigationParameters parameters)
        {
            // VENGO DE UN SITIO

            // SOMETHING LIKE THIS
            var title = parameters["MyTitle"];

            MyTitle = title.ToString();

        }
    }
}
