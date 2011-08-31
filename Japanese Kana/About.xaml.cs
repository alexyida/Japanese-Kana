using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Japanese_Kana
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
            if (App.IsTrial)
            {
                BuyHB.Visibility = System.Windows.Visibility.Visible;
                ApplicationTitle.Text = "JAPANESE KANA - TRIAL";
            }
            else
            {
                BuyHB.Visibility = System.Windows.Visibility.Collapsed;
                ApplicationTitle.Text = "JAPANESE KANA";
            }
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Phone.Tasks.EmailComposeTask email = new Microsoft.Phone.Tasks.EmailComposeTask();
            email.To = "alexyida@live.ca";
            email.Subject = "[Japanese Kana 2.0] feedback";
            email.Body = "Hi AlexGeekie, " + Environment.NewLine;
            email.Show();
        }

        private void Rate_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Phone.Tasks.MarketplaceReviewTask market = new Microsoft.Phone.Tasks.MarketplaceReviewTask();
            market.Show();
        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Phone.Tasks.WebBrowserTask web = new Microsoft.Phone.Tasks.WebBrowserTask();
            web.Uri = new Uri("http://alexyw.wordpress.com/dev/japanese-kana/");
            web.Show();
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Phone.Tasks.MarketplaceDetailTask buy = new Microsoft.Phone.Tasks.MarketplaceDetailTask();
            buy.Show();
        }
    }
}