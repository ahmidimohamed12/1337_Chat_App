using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class informationapp : ContentPage
    {
        public informationapp()
        {
            InitializeComponent();
            var n = new TapGestureRecognizer();
            n.Tapped += btn_click;
            lt.GestureRecognizers.Add(n);
        }
        private async void btn_click(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new Regpage());
        }
    }
}