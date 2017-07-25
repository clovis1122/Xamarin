using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.ViewModels
{
    class HomePageViewModel
    {
        INavigationService _navigationService;
        IPageDialogService _pagedialogService;
        public DelegateCommand OnGoCommand { get; set; }

        // Con la interfaz de INavigationService, se debe utilizar esta obligatoriamente.

        public HomePageViewModel(INavigationService navigationService, IPageDialogService pageDialog)
        {
            _navigationService = navigationService;
            _pagedialogService = pageDialog;
            OnGoCommand = new DelegateCommand(Navegame);
        }

        void ShowAlert()
        {
            _pagedialogService.DisplayActionSheetAsync("HELLOOOOOOOU ADEURY PRESTA ATENCION");
        }
        async void Navegame()
        {
            var param = new NavigationParameters();
            param.Add("MyTitle", "klk");

            // El tercer parametro especifica como se hara el cambio de pagina.
            await _navigationService.NavigateAsync(new Uri("HomePage", UriKind.Relative),param);

            await _navigationService.GoBackAsync();

        }
    }
}
