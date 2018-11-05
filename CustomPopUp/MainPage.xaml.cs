using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomPopUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPopupButton_Clicked(object sender, EventArgs e)
        {
            //popupLoadingView.IsVisible = true;
            //activityIndicator.IsRunning = true;

            Navigation.PushModalAsync(new MyPopUp(), false);

            Device.StartTimer(TimeSpan.FromSeconds(5),() => {
                //popupLoadingView.IsVisible = false;
                //activityIndicator.IsRunning = false;

                Navigation.PopModalAsync(false);

                return true;
            });

        }
    }
}
