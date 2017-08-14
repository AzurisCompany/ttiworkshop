using Xamarin.Forms;

namespace FlightApp
{
    public partial class App : Application
    {         
        public App()
        {
            InitializeComponent();                                  
            MainPage = new NavigationPage(new Pages.Menu()) { BarBackgroundColor = Color.FromHex("#e9c813") };
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
