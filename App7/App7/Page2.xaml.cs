using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App7.Model;
using System.Collections.ObjectModel;
using System.Globalization;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            flightActions = new List<FlightAction>() {
                new FlightAction
                {
                    Title = "FLIGHT DETAILS",
                    Image = "md-build"

                },
                new FlightAction
                {
                    Title = "UPGRADE SEAT",
                    Image = "md-lock"
                },
                new FlightAction
                {
                    Title = "CHECK BAGS",
                    Image = "md-favorite"
                },
                new FlightAction
                {
                    Title = "ENTERTAINMENT",
                    Image = "md-alarm"
                },
                 new FlightAction
                {
                    Title = "ENTERTAINMENT",
                    Image = "md-list"
                }
            };
            flightInfo = new Flight() {
                Term = 1,
                Gate = "A5",
                Seat = "5A",
                Departure = new DateTime(),
                Status = "ON TIME"
            };

            actionsListView.ItemsSource = flightActions;
            flightInfoBox.BindingContext = flightInfo;
        }
        public static IList<FlightAction> flightActions { get; set; }
        public static Flight flightInfo { get; set; }
        private async void FlightListClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new FlightList());
        }
    }

    public class StatusToIconConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString().ToLower() == "on time")
            {
                return "md-done";
            }
            else
            {
                return "md-lock";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class TestConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString() + ';';
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}