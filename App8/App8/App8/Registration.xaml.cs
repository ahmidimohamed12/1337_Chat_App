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
    public partial class Registration : ContentPage
    {
        public int imtappedfr = 0;

        public static int m = 0;
        public Registration()
        {
            InitializeComponent();
            Guest_click(iml, im_click);

            btnreg.Clicked += reg;
            btnlg.Clicked += click_con;
        }

        private async void click_con(object sende,EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
        private async void reg(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new Regpage());
        }
        private void Guest_click(Image im, EventHandler e)
        {
            var n = new TapGestureRecognizer();
            n.Tapped += e;
            im.GestureRecognizers.Add(n);
         
        }
        private void im_click(object sender, EventArgs e)
        {
            imtappedfr++;
            if (imtappedfr % 2 == 0)
            {
                iml.Source = ImageSource.FromFile("fr.png");
                m = 1;
          
            }
            else
            {
                m = 2;
                iml.Source = ImageSource.FromFile("morocco.png");
            }


        }
    }
}