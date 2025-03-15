using System;
using TP15.BanqueApp.Services;
using TP15.BanqueApp.Models;

class Program
{
    static void Main()
    {
        GestionComptes gestionComptes = new GestionComptes();
        Authentification auth = new Authentification();

        Console.WriteLine("Bienvenue dans l'application de gestion des comptes bancaires");
        var utilisateur = auth.AuthentifierUtilisateur();
        if (utilisateur == null)
        {
            Console.WriteLine("Échec de connexion. Fin du programme.");
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Créer un compte");
            Console.WriteLine("2. Afficher tous les comptes");
            Console.WriteLine("3. Rechercher un compte");
            Console.WriteLine("4. Supprimer un compte");
            Console.WriteLine("5. Quitter");
            Console.Write("Choisissez une option : ");
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1": gestionComptes.CreerCompte(); break;
                case "2": gestionComptes.AfficherTousComptes(); break;
                case "3": gestionComptes.RechercherCompte(); break;
                case "4": gestionComptes.SupprimerCompte(); break;
                case "5": gestionComptes.EnregistrerComptes(); return;
                default: Console.WriteLine("Option invalide"); break;
            }
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}