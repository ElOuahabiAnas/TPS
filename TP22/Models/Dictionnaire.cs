namespace TP22.Models
{
    public class Dictionnaire : Document
    {
        public string Langue { get; set; }
        public int NombreDefinitions { get; set; }

        public Dictionnaire(string titre, string langue, int nombreDefinitions) : base(titre)
        {
            this.Langue = langue;
            this.NombreDefinitions = nombreDefinitions;
        }

        public override string Description()
        {
            return $"[Dictionnaire] N°{Numero} - \"{Titre}\" en {Langue}, {NombreDefinitions} définitions.";
        }
    }
}