using LayoutTwitter.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayoutTwitter.services
{
    public interface ITwitterService
    {
        bool authenticate(string identifiant, string password);
        List<Tweet> getTweets(string texte);
    }
}
