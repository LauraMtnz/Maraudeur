using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Maraudeur
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

            base.OnAppearing();


            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(43.570240, 1.464874), Distance.FromKilometers(100000)));

            var pinNDL = new Pin
            {
                Type = PinType.Place,
                Position = new Position(43.570240, 1.464874),
                Label = "Nuit de l'Info 2018 !",
                Address = "Toulouse, France"
            };
            map.Pins.Add(pinNDL);


            var pinMuraille = new Pin
            {
                Type = PinType.Place,
                Position = new Position(40.432111, 116.570443),
                Label = "La Grande Muraille",
                Address = "Chine"
            };
            map.Pins.Add(pinMuraille);


            var pinPetra = new Pin
            {
                Type = PinType.Place,
                Position = new Position(30.328460, 35.444362),
                Label = "Pétra",
                Address = "Uum Sayhoun, Jordanie"
            };
            map.Pins.Add(pinPetra);


            var pinChristRio = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-22.951827, -43.210498),
                Label = "Christ rédempteur",
                Address = "Rio de Janeiro, Brésil"
            };
            map.Pins.Add(pinChristRio);


            var pinMachuPicchu = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-13.163058, -72.544963),
                Label = "Machu Picchu",
                Address = "Aguas calientes, Pérou"
            };
            map.Pins.Add(pinMachuPicchu);

            var pinChichen = new Pin
            {
                Type = PinType.Place,
                Position = new Position(20.684305, -88.567783),
                Label = "Chichén Itzá",
                Address = "Yucatán, Mexique"
            };
            map.Pins.Add(pinChichen);


            var pinColisee = new Pin
            {
                Type = PinType.Place,
                Position = new Position(41.890258, 12.492209),
                Label = "Colisée",
                Address = "Rome, Italie"
            };
            map.Pins.Add(pinColisee);


            var pinTajMahal = new Pin
            {
                Type = PinType.Place,
                Position = new Position(27.175053, 78.042134),
                Label = "Taj Mahal",
                Address = "Agra, Uttar Pradesh, Inde"
            };
            map.Pins.Add(pinTajMahal);
        }
    }
}
