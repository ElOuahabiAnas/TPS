
using System;
using System.Collections.Generic;

namespace TP15.BanqueApp.Models
{
    public class CompteBancaire
    {
        public string Numero { get; }
        public string Titulaire { get; }
        public double Solde { get; private set; }
        private List<string> historique = new List<string>();

        public CompteBancaire(string numero, string titulaire, double solde)
        {
            Numero = numero;
            Titulaire = titulaire;
            Solde = solde;
        }

        public void Crediter(double montant)
        {
            Solde += montant;
            historique.Add($"Crédité: {montant} | Solde: {Solde} | {DateTime.Now}");
        }

        public bool Debiter(double montant)
        {
            if (Solde >= montant)
            {
                Solde -= montant;
                historique.Add($"Débité: {montant} | Solde: {Solde} | {DateTime.Now}");
                return true;
            }
            return false;
        }

        public bool Transferer(CompteBancaire destinataire, double montant)
        {
            if (Debiter(montant))
            {
                destinataire.Crediter(montant);
                return true;
            }
            return false;
        }

        public void AfficherHistorique()
        {
            foreach (var entry in historique)
                Console.WriteLine(entry);
        }

        public override string ToString()
        {
            return $"{Numero} - {Titulaire} - {Solde} DH";
        }
    }
}
