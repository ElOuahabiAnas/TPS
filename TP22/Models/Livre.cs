namespace TP22.Models
{
    public class Livre : Document
    {
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        public Livre(string titre, string auteur, int nombrePages) : base(titre)
        {
            this.Auteur = auteur;
            this.NombrePages = nombrePages;
        }

        public override string Description()
        {
            return $"[Livre] N°{Numero} - \"{Titre}\" de {Auteur}, {NombrePages} pages.";
        }
    }
}