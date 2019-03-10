using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async  void FlightsClicked(object sender, EventArgs e)
        {
            var flightpage = new Page2();
            await this.Navigation.PushAsync(flightpage);
        }
    }
}
