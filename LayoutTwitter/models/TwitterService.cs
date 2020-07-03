using LayoutTwitter.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LayoutTwitter.models
{
    public  class TwitterService : ITwitterService
    {

        string identifiant = null;
        string password = null;

        List<Tweet> tweets = new List<Tweet>
        {
            new Tweet
            {
                Id=1,
                DateCreation="20/12/2019",
                Texte="Hello World",
                Nom="Yoanne",
                Identifiant="password",
                Pseudo="Yoyo"


            },
           /* new Tweet
            {
                Id=2,
                DateCreation="18/06/2020",
                Texte="Coucou les amis ! Bonnes vancances",
                Nom="Yoanne",
                Identifiant="passwo",                                                                                                                                                                                                                                                             t="password",
                Pseudo="Yoyo"


            },*/
            new Tweet
            {
                Id=3,
                DateCreation="16/05/2020",
                Texte="Découvrez la nouvelle spécialité de chez Papo",
                Nom="Paul",
                Identifiant="toto",
                Pseudo="Papo"


            }

        };

        public bool authenticate(string identifiant, string password)
        {
            if (string.IsNullOrEmpty(identifiant) || string.IsNullOrEmpty(password) || identifiant.Length < 3 || password.Length < 6)
            {
                return false;
            }

            else if (identifiant.Equals("Yoyo") &&
           password.Equals("password"))
            {
                this.identifiant = identifiant;
                this.password = password;
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tweet> getTweets()
        {
            

            return (this.tweets);
        }
    }
}
