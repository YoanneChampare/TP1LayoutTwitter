using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }


        private void connexionClick(object sender, EventArgs e)
        {
            bool acces = true;
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
            }

        }

        private void afficherErreur(string message)
        {
            this.erreur.IsVisible = true;
            this.erreur.Text = message;
        }
        
        private void cacherErreur()
        {
            this.erreur.IsVisible = false;
        }
    }
}
