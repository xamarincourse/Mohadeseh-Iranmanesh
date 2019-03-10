using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App7.Model;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlightList : ContentPage
    {
        public FlightList()
        {
            InitializeComponent();
            Flights = new List<Flight>()
            {
                new Flight(){
                    FlightNumber = "9w2273",
                    DepartureAirport = "London",
                    STA = "14:20",
                    ETA = "14:35",
                    Terminal = "T3",
                    Status = "Arrived"
                },
                new Flight(){
                    FlightNumber = "9w2245",
                    DepartureAirport = "Paris",
                    STA = "14:20",
                    ETA = "14:35",
                    Terminal = "T3",
                    Status = "Arrived"
                },
                new Flight(){
                    FlightNumber = "9w2343",
                    DepartureAirport = "Dubai",
                    STA = "14:20",
                    ETA = "14:35",
                    Terminal = "T3",
                    Status = "Delayed"
                },
                new Flight(){
                    FlightNumber = "9w2273",
                    DepartureAirport = "New York",
                    STA = "14:20",
                    ETA = "14:35",
                    Terminal = "T3",
                    Status = "Arrived"
                },
                new Flight(){
                    FlightNumber = "9w2273",
                    DepartureAirport = "Rome",
                    STA = "14:20",
                    ETA = "14:35",
                    Terminal = "T3",
                    Status = "Delayed"
                },
                new Flight(){
                    FlightNumber = "9w2273",
                    DepartureAirport = "Kerman",
                    STA = "14:20",
                    ETA = "14:35",
                    Terminal = "T3",
                    Status = "Arrived"
                }
            };
            listView.ItemsSource = Flights;

        }
        public List<Flight> Flights { get; set; }
    }
}