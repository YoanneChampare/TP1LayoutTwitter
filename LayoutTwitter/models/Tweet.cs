using System;
using System.Collections.Generic;
using System.Text;

namespace LayoutTwitter.models
{
    public class Tweet
    {
        public int Id { get; set; }
        public string DateCreation { get; set; }
        public string Texte { get; set; }
        public string Nom { get; set; }
        public string Identifiant { get; set; }
        public string Pseudo { get; set; }
    }
}
