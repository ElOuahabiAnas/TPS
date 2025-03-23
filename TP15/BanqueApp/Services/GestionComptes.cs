using System;
using System.Collections.Generic;
using System.IO;
using TP15.BanqueApp.Models;

namespace TP15.BanqueApp.Services
{
    public class GestionComptes
    {
        private List<CompteBancaire> comptes = new List<CompteBancaire>();
        private string dataFile = "comptes.txt";

        public GestionComptes()
        {
            ChargerComptes();
        }

        public void CreerCompte()
        {
            Console.Write("Numéro du compte : ");
            string numero = Console.ReadLine();
            Console.Write("Titulaire : ");
            string titulaire = Console.ReadLine();
            Console.Write("Solde initial : ");
            double solde = double.Parse(Console.ReadLine());

            comptes.Add(new CompteBancaire(numero, titulaire, solde));
            Console.WriteLine("Compte créé avec succès !");
        }

        public void AfficherTousComptes()
        {
            Console.WriteLine("Liste des comptes bancaires :");
            foreach (var compte in comptes)
                Console.WriteLine(compte);
        }

        public void RechercherCompte()
        {
            Console.Write("Numéro du compte : ");
            string numero = Console.ReadLine();
            var compte = comptes.Find(c => c.Numero == numero);

            if (compte != null)
                Console.WriteLine(compte);
            else
                Console.WriteLine("Compte introuvable !");
        }

        public void SupprimerCompte()
        {
            Console.Write("Numéro du compte à supprimer : ");
            string numero = Console.ReadLine();
            var compte = comptes.Find(c => c.Numero == numero);

            if (compte != null)
            {
                comptes.Remove(compte);
                Console.WriteLine("Compte supprimé !");
            }
            else
                Console.WriteLine("Compte introuvable !");
        }

        public void EnregistrerComptes()
        {
            using (StreamWriter sw = new StreamWriter(dataFile))
            {
                foreach (var compte in comptes)
                    sw.WriteLine($"{compte.Numero};{compte.Titulaire};{compte.Solde}");
            }
        }

        private void ChargerComptes()
        {
            Console.WriteLine($"Chemin de recherche du fichier : {Path.GetFullPath(dataFile)}");

            if (File.Exists(dataFile))
            {
                string[] lignes = File.ReadAllLines(dataFile);
                foreach (var ligne in lignes)
                {
                    var data = ligne.Split(';');
                    comptes.Add(new CompteBancaire(data[0], data[1], double.Parse(data[2])));
                }
            }
        }
    }
}
