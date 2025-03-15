using System;
using TP21.Models;

namespace TP21
{
    class Program
    {
        static void Main()
        {
            GestionEmployes gestion = new GestionEmployes();

            // Ajout des employés
            gestion.AjouterEmploye(new Employee("Ali", 12000, "Développeur", new DateTime(2020, 5, 10)));
            gestion.AjouterEmploye(new Employee("Sara", 15000, "Manager", new DateTime(2018, 3, 22)));
            gestion.AjouterEmploye(new Employee("Omar", 10000, "Analyste", new DateTime(2021, 7, 15)));

            // Affichage des employés
            Console.WriteLine("Liste des employés:");
            gestion.AfficherTousLesEmployes();

            // Gestion du directeur
            Directeur directeur = Directeur.Instance;
            directeur.SetGestionEmployes(gestion);

            // Affichage des infos générales
            Console.WriteLine("\nInformations sur l'entreprise:");
            directeur.AfficherInfosEntreprise();

            // Suppression d'un employé
            Console.WriteLine("\nSuppression d'un employé (Ali)...");
            gestion.SupprimerEmploye("Ali");

            // Affichage mis à jour
            Console.WriteLine("\nListe mise à jour des employés:");
            gestion.AfficherTousLesEmployes();

            // Affichage mis à jour des informations générales
            Console.WriteLine("\nInformations mises à jour sur l'entreprise:");
            directeur.AfficherInfosEntreprise();
        }
    }
}