using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App8.Model;
using System.Threading.Tasks;
using Firebase.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin : ContentPage
    {
        public FirebaseClient firebase = new FirebaseClient("https://project-655056407821009696.firebaseio.com/");
        public Admin()
        {
            InitializeComponent();
            bt.Clicked += btn_click;
        }
      
        private async void btn_click(object sender, EventArgs e)
        {
            await  DataHelp.AddPerson(txt1.Text, txt2.Text);
        }
    }
}