using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio07
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new ViewToViewDemo());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new BindingModeDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new ListViewDemo());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new PickerDemo());
            };
        }
    }
}
