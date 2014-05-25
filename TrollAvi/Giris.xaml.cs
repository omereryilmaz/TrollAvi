using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TrollAvi
{
    public partial class Giris : PhoneApplicationPage
    {
        public Giris()
        {
            //http://www.omereryilmaz.com/ 
            InitializeComponent();
			Storyboard1.Begin(); //giriş animasyonumuzu çağırıyoruz
        }

        private void girButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.RelativeOrAbsolute));
        }

       

       
    }
}