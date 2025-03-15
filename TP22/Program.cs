using System;
using TP22.Models;
using TP22.Services;

namespace TP22
{
    class Program
    {
        static void Main()
        {
            Biblio bibliotheque = new Biblio();

            // Ajout de documents
            bibliotheque.AjouterDocument(new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", 96));
            bibliotheque.AjouterDocument(new Livre("1984", "George Orwell", 328));
            bibliotheque.AjouterDocument(new Dictionnaire("Larousse Français", "Français", 60000));
            bibliotheque.AjouterDocument(new Dictionnaire("Oxford English", "Anglais", 50000));

            Console.WriteLine("===== Tous les documents =====");
            bibliotheque.ToutesLesDescriptions();

            Console.WriteLine("\n===== Nombre de livres =====");
            Console.WriteLine($"Nombre de livres dans la bibliothèque : {bibliotheque.NombreDeLivres()}");

            Console.WriteLine("\n===== Liste des dictionnaires =====");
            bibliotheque.AfficherDictionnaires();

            Console.WriteLine("\n===== Liste des auteurs =====");
            bibliotheque.TousLesAuteurs();
        }
    }
}