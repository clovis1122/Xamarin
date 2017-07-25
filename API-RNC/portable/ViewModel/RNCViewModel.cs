using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Practica5.Services;
using Plugin.Connectivity;

namespace Practica5.ViewModel
{
    public class RNCViewModel : INotifyPropertyChanged
    {
        public ICommand buttonClick { get; set; }
        

        IApiRNC _apiService = new ApiRNC();

        public event PropertyChangedEventHandler PropertyChanged;

        public string rnc { get; set; }
        public string name { get; set; }
        public bool hasResult { get; set; }
        public bool isBusy { get; set; }
        public string category { get; set; }
        public string paymentStatus { get; set; }
        public string commercialName { get; set; }
        public string paymentRegimen { get; set; }

        public RNCViewModel()
        {
            buttonClick = new Command(onButtonClick);
            this.hasResult = false;
        }

        public async void onButtonClick()
        {
            this.isBusy = true;
            try
            {
                if (!CrossConnectivity.Current.IsConnected)
                {
                    await App.Current.MainPage.DisplayAlert("Error", "No internet connection found", "OK");
                    return;
                }
            }
            catch(Exception e)
            {
                // TODO: Fix the internet issue.
                return;
            }



            var jsonResult = await _apiService.GetRNC(this.rnc);

            if (jsonResult.rnc != null)
            {
                this.rnc = jsonResult.rnc;
                this.name = jsonResult.name;
                this.commercialName = jsonResult.comercialName;
                this.category = jsonResult.category;
                this.paymentRegimen = jsonResult.paymentRegimen;
                this.paymentStatus = jsonResult.status;
                this.hasResult = true;
                this.isBusy = false;
            } else
            {
                this.isBusy = false;
                await App.Current.MainPage.DisplayAlert("Error", "Unable to get the RNC", "OK");
            }

        }


    }
}
