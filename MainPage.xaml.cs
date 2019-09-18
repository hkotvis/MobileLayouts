using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActivityLayouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void navigateGrid(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid());
        }
        private async void navigateAbsolute(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Absolute());
        }
        private async void navigateRelative(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Relative());
        }
        private async void navigateFlex(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Flex());
        }
    }
}
