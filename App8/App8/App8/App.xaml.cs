using Xamarin.Forms;
using Plugin.WifiInfo;
using Plugin.Connectivity.Abstractions;
using Plugin.Connectivity;
namespace App8
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var r = Plugin.Connectivity.CrossConnectivity.Current;

            if (r.IsConnected)
                MainPage = new MainPage();
            else
                MainPage = new Connection();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
