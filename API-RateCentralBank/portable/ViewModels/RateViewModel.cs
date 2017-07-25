using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateCentralBankSample.Services;
using System.ComponentModel;

namespace RateCentralBankSample.ViewModels
{
    class RateViewModel : INotifyPropertyChanged
    {
        public string BuyRate { get; set; }
        public string SellRate { get; set; }
        IApiService _apiService = new ApiService();

        public bool IsBusy { get; set; }
        public event PropertyChangedEventHandler PropertyChanged; 

        public RateViewModel()
        {
            LoadData();
        }

        public async void LoadData()
        {
            try
            {
                IsBusy = true;
                var response = await _apiService.GetDollarRate();
                if (response != null)
                {
                    BuyRate = response.dollar.Buying_rate;
                    SellRate = response.dollar.Selling_rate;
                }
                IsBusy = false;

            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Unable to get data","OK");
            }
        }
    }
}
