using System;

namespace TP21.Models
{
    public class Employee
    {
        public string Nom { get; set; }
        public double Salaire { get; set; }
        public string Poste { get; set; }
        public DateTime DateEmbauche { get; set; }

        public Employee(string nom, double salaire, string poste, DateTime dateEmbauche)
        {
            Nom = nom;
            Salaire = salaire;
            Poste = poste;
            DateEmbauche = dateEmbauche;
        }

        public void AfficherInfo()
        {
            Console.WriteLine($"Nom: {Nom}, Salaire: {Salaire} DH, Poste: {Poste}, Date d'embauche: {DateEmbauche.ToShortDateString()}");
        }
    }
}