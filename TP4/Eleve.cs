namespace TP4
{
    public class Eleve
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Groupe { get; set; }

        public Eleve(int id, string nom, string prenom, string groupe)
        {
            ID = id;
            Nom = nom;
            Prenom = prenom;
            Groupe = groupe;
        }

        public Eleve(string nom, string prenom, string groupe)
        {
            Nom = nom;
            Prenom = prenom;
            Groupe = groupe;
        }
    }

    
}