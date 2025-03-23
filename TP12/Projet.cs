namespace TP2;

using System;
using System.Collections.Generic;

public class Projet
{
    private string Code;
    private string Sujet;
    private int DureeSemaines;
    private List<Programmeur> Programmeurs;

    public Projet(string code, string sujet, int duree)
    {
        Code = code;
        Sujet = sujet;
        DureeSemaines = duree;
        Programmeurs = new List<Programmeur>();
    }

    public string code
    {
        get { return Code; }
    }

    public string sujet
    {
        get { return Sujet; }
    }

    public int dureeSemaines
    {
        get { return DureeSemaines; }
    }

    public void AjouterProgrammeur(Programmeur p)
    {
        if (p != null)
        {
            Programmeurs.Add(p);
            Console.WriteLine($"Programmeur {p.nom} ajouté avec succès.");
        }
        else
        {
            Console.WriteLine("Programmeur invalide.");
        }
    }

    public Programmeur RechercherProgrammeur(string nom)
    {
        foreach (var p in Programmeurs)
        {
            if (p.nom.Equals(nom, StringComparison.OrdinalIgnoreCase))
                return p;
        }
        return null;
    }

    public void AfficherProgrammeur(string nom)
    {
        Programmeur p = RechercherProgrammeur(nom);
        if (p != null)
            Console.WriteLine(p);
        else
            Console.WriteLine("Programmeur introuvable.");
    }

    public void AfficherTousProgrammeurs()
    {
        if (Programmeurs.Count == 0)
        {
            Console.WriteLine("Aucun programmeur enregistre.");
            return;
        }

        foreach (Programmeur p in Programmeurs)
        {
            Console.WriteLine(p);
        }
    }

    public void SupprimerProgrammeur(string nom)
    {
        Programmeur p = RechercherProgrammeur(nom);
        if (p != null)
        {
            Programmeurs.Remove(p);
            Console.WriteLine($"Programmeur {nom} supprime.");
        }
        else
        {
            Console.WriteLine("Programmeur introuvable.");
        }
    }

    public void AjouterConsommationCafe(string nom, int semaine, int tasses)
    {
        Programmeur p = RechercherProgrammeur(nom);
        if (p != null)
        {
            p.AjouterConsommation(semaine, tasses);
            Console.WriteLine("Consommation de cafe ajoutee.");
        }
        else
        {
            Console.WriteLine("Programmeur introuvable.");
        }
    }

    public void ChangerBureau(string nom, string nouveauBureau)
    {
        Programmeur p = RechercherProgrammeur(nom);
        if (p != null)
        {
            p.bureau = nouveauBureau;
            Console.WriteLine("Bureau mis a jour.");
        }
        else
        {
            Console.WriteLine("Programmeur introuvable.");
        }
    }

    public void TotalCafeSemaine(int semaine)
    {
        int total = 0;
        foreach (var p in Programmeurs)
        {
            total += p.GetConsommationSemaine(semaine);
        }
        Console.WriteLine($"Total de tasses de cafe consommees en semaine {semaine} : {total}");
    }
    public void AfficherTotalCafeParProgrammeur()
    {
        foreach (var p in Programmeurs)
        {
            int total = 0;
            for (int i = 0; i < dureeSemaines; i++)
            {
                total += p.GetConsommationSemaine(i);
            }
            Console.WriteLine($"{p.nom} : {total} tasses");
        }
    }

}
