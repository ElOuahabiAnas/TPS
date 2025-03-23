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
            if (nom != null)
            {
                for (int i = employes.Count - 1; i >= 0; i--)
                {
                    if (employes[i].Nom == nom)
                    {
                        employes.RemoveAt(i);
                        Console.WriteLine($"Employé {nom} supprimé.");
                    }
                }
            }
        }


        public double CalculerSalaireTotal()
        {
            double totale = 0;
            if (employes.Count == 0) return totale;
            foreach (Employee emp in employes)
            {
                totale += emp.Salaire;
            }
            return totale;
        }


        public double CalculerSalaireMoyen()
        {
            if (employes.Count == 0) return 0;
            double totale = CalculerSalaireTotal();
            return totale / employes.Count;
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