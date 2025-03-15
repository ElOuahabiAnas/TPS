using System;
using System.Collections.Generic;
using TP22.Models;

namespace TP22.Services
{
    public class Biblio
    {
        private List<Document> documents;

        public Biblio()
        {
            this.documents = new List<Document>();
        }

        // Ajouter un document
        public void AjouterDocument(Document doc)
        {
            documents.Add(doc);
        }

        // Compter le nombre de livres
        public int NombreDeLivres()
        {
            int count = 0;
            foreach (var doc in documents)
            {
                if (doc is Livre)
                    count++;
            }
            return count;
        }

        // Afficher uniquement les dictionnaires
        public void AfficherDictionnaires()
        {
            foreach (var doc in documents)
            {
                if (doc is Dictionnaire)
                    Console.WriteLine(doc.Description());
            }
        }

        // Afficher tous les auteurs (avec numéro du document)
        public void TousLesAuteurs()
        {
            foreach (var doc in documents)
            {
                if (doc is Livre livre)
                    Console.WriteLine($"Document N°{doc.Numero} - Auteur : {livre.Auteur}");
                else
                    Console.WriteLine($"Document N°{doc.Numero} - Pas d'auteur.");
            }
        }

        // Afficher toutes les descriptions des documents
        public void ToutesLesDescriptions()
        {
            foreach (var doc in documents)
            {
                Console.WriteLine(doc.Description());
            }
        }
    }
}