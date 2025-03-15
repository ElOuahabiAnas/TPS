using System;
using System.Collections.Generic;
using System.Linq;

namespace TP21.Models
{
    public class GestionEmployes
    {
        private List<Employee> employes = new List<Employee>();

        public void AjouterEmploye(Employee employe)
        {
            employes.Add(employe);
        }

        public void SupprimerEmploye(string nom)
        {
            var employe = employes.FirstOrDefault(e => e.Nom == nom);
            if (employe != null)
            {
                employes.Remove(employe);
                Console.WriteLine($"Employé {nom} supprimé.");
            }
            else
            {
                Console.WriteLine($"Aucun employé trouvé avec le nom {nom}.");
            }
        }

        public double CalculerSalaireTotal()
        {
            return employes.Sum(e => e.Salaire);
        }

        public double CalculerSalaireMoyen()
        {
            return employes.Count > 0 ? employes.Average(e => e.Salaire) : 0;
        }

        public void AfficherTousLesEmployes()
        {
            foreach (var employe in employes)
            {
                employe.AfficherInfo();
            }
        }
    }
}