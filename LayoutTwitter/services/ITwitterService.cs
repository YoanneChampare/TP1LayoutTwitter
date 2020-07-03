using LayoutTwitter.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LayoutTwitter.services
{
    public interface ITwitterService
    {
        bool authenticate(string identifiant, string password);
        List<Tweet> getTweets();
    }
}
