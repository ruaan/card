using Deetsme.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Deetsme
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            var page = new NavigationPage(new Login());
            page.BarBackgroundColor = Color.FromHex("#0082C9");
            page.BarTextColor = Color.White;

            MainPage = page;
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
