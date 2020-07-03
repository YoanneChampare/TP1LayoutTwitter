using LayoutTwitter.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutTwitter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeTweet : ContentPage
    {

       
        public ListeTweet()
        {
            InitializeComponent();
            TwitterService ts = new TwitterService();

            var tweet = ts.getTweets();

            this.liste.ItemsSource = tweet;
        }
    }
}