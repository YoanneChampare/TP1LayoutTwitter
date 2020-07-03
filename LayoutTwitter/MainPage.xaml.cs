using LayoutTwitter.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LayoutTwitter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            verificationNetwork();
          
        }

        private bool verificationNetwork()
        {
            cacherEtatNetWork();
           var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                this.afficherEtatNetwork("Connexion internet OK");
                return true;
            }
            else
            {
                this.afficherEtatNetwork("Pas de connexion internet");
                return false;
            }
        }

       

        TwitterService ts = new TwitterService();
        
        private void connexionClick(object sender, EventArgs e)
        {
            verificationNetwork();
            bool connexion = ts.authenticate(this.identifiant.Text, this.password.Text);
            if (verificationNetwork())
            {
                if (!connexion)
                {
                    this.afficherErreur("Identifiant ou mot de passe incorrect");

                }
                else
                {
                    /* this.tweet.IsVisible = true;

                     this.formulaire.IsVisible = false;*/
                    afficherListeTweet();
                }

            }
            

            /* bool acces = true;
             this.cacherErreur();
             if (this.identifiant.Text==null || string.IsNullOrEmpty(this.identifiant.ToString()) || this.identifiant.Text.Length < 3)
             {
                 acces = false;
                 this.afficherErreur("Identifiant trop court !");
             }

             if (this.password.Text== null || string.IsNullOrEmpty(this.password.ToString()) || this.password.Text.Length < 6)
             {
                 acces = false;
                 this.afficherErreur("Mot de passe trop court !");
             }

             if (acces)
             {
                 this.tweet.IsVisible = true;
                 this.formulaire.IsVisible = false;

             }*/

        }

        private async void afficherListeTweet()
        {
           await Navigation.PushAsync(new ListeTweet());
        }

        private void afficherErreur(string message)
        {
            this.erreur.IsVisible = true;
            this.erreur.Text = message;
        }

        private void afficherEtatNetwork(string message)
        {
            this.network.IsVisible = true;
            this.network.Text = message;
        }

        private void cacherErreur()
        {
            this.erreur.IsVisible = false;
        }

        private void cacherEtatNetWork()
        {
            this.network.IsVisible = false;
        }
    }
}
