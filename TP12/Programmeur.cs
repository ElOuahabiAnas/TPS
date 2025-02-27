namespace TP2;

using System;

public class Programmeur
{
    private string Nom;
    private string Prenom;
    private string Bureau;
    private int[] ConsommationCafe; // Stocke la consommation de cafe par semaine

    public Programmeur(string nom, string prenom, int nombreSemaines)
    {
        Nom = nom;
        Prenom = prenom;
        Bureau = "Non attribue"; // Par defaut
        ConsommationCafe = new int[nombreSemaines];
    }

    public string nom
    {
        get { return Nom; }
    }

    public string prenom
    {
        get { return Prenom; }
    }

    public string bureau
    {
        get { return Bureau; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                Bureau = value;
            else
                throw new ArgumentException("Le bureau ne peut pas etre vide.");
        }
    }

    public void AjouterConsommation(int semaine, int tasses)
    {
        if (semaine >= 0 && semaine < ConsommationCafe.Length)
        {
            if (tasses >= 0)
                ConsommationCafe[semaine] += tasses;
            else
                throw new ArgumentException("Le nombre de tasses doit etre positif.");
        }
        else
        {
            throw new IndexOutOfRangeException("Semaine invalide.");
        }
    }

    public int GetConsommationSemaine(int semaine)
    {
        if (semaine >= 0 && semaine < ConsommationCafe.Length)
            return ConsommationCafe[semaine];
        else
            throw new IndexOutOfRangeException("Semaine invalide.");
    }

    public override string ToString()
    {
        return $"{Nom} {Prenom} - Bureau: {Bureau}";
    }
}
