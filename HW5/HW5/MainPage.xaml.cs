using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System.Diagnostics;

namespace HW5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //Map map;
        int counter = 0;
        public MainPage()
        {
            InitializeComponent();
            

            var street = new Button { Text = "Street" };
            var satellite = new Button { Text = "Satellite" };
            street.Clicked += Button_Clicked;
            satellite.Clicked += Button_Clicked2;

            segments.Spacing = 30;
            segments.HorizontalOptions = LayoutOptions.CenterAndExpand;
            segments.Orientation = StackOrientation.Horizontal;
            segments.Children.Add(street);
            segments.Children.Add(satellite);

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            stack.Children.Add(segments);
            Content = stack; 
        }


        void Button_Clicked(object sender, EventArgs e) //switches view to street
        {
                    map.MapType = MapType.Street;
        }
        void Button_Clicked2(object sender, EventArgs e) //switches view to satellite
        {
                    map.MapType = MapType.Satellite;
        }
    }
}
