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
    public partial class Regpage : ContentPage
    {
        public Regpage()
        {
            InitializeComponent();
            var n = new TapGestureRecognizer();
            n.Tapped += btnback_click;
            btnback.GestureRecognizers.Add(n);

            var nn = new TapGestureRecognizer();
            nn.Tapped += info_click;
            inf.GestureRecognizers.Add(nn);
        }
        private async void btnback_click(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new Registration());
        }

        private async void info_click(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new informationapp());
        }
    }
}