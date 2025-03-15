using System;

namespace TP22.Models
{
    public abstract class Document
    {
        private static int compteur = 1;
        public int Numero { get; }
        public string Titre { get; set; }

        public Document(string titre)
        {
            this.Numero = compteur++;
            this.Titre = titre;
        }

        public abstract string Description();
    }
}