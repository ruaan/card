using Deetsme.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Deetsme
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<ListViewModel> _listview = new ObservableCollection<ListViewModel>();

        public MainPage()
        {
            InitializeComponent();

            DeetsImage.Source = ImageSource.FromResource("Deetsme.Images.deetsLogo.png");
            sms.Source = ImageSource.FromResource("Deetsme.Images.sms.png");
            email.Source = ImageSource.FromResource("Deetsme.Images.emaillogo.png");
            whatsapp.Source = ImageSource.FromResource("Deetsme.Images.whatsapp.png");

            _listview.Add(new ListViewModel { Image = ImageSource.FromResource("Deetsme.Images.phone.png"), Text = "074 492 5023" });
            _listview.Add(new ListViewModel { Image = ImageSource.FromResource("Deetsme.Images.email.png"), Text = "jenny@deetsme.com" });
            _listview.Add(new ListViewModel { Image = ImageSource.FromResource("Deetsme.Images.website.png"), Text = "www.deetsme.com" });
            _listview.Add(new ListViewModel { Image = ImageSource.FromResource("Deetsme.Images.location.png"), Text = "35 Waterloo Ave Samrand Kosmosdal Centurion" });
            _listview.Add(new ListViewModel { Image = ImageSource.FromResource("Deetsme.Images.save.png"), Text = "Save Card" });

            ListView.ItemsSource = _listview;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView.SelectedItem = null;
        }
    }
}
