using System;

public class Fichier
{
    private string Nom;
    private string Extension;
    private float Taille;

    public Fichier(string nom, string extension, float taille)
    {
        Nom = nom;
        Extension = extension;
        Taille = taille;
    }


    public string nom
    {
        get { return Nom; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                Nom = value;
            else
                throw new ArgumentException("le nom du fichier ne peut pas étre vide");
        }
    }

    public string extension
    {
        get { return Extension; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                Extension = value;
            else throw new ArgumentException("l'extension du fhcier ne peut pas etre vide");
        }
    }

    public float taille
    {
        get { return Taille; }
        set
        {
            if(value > 0)
                Taille = value;
            else throw new ArgumentException("l'taille du fichier doit étre supérieur à 0");
        }
    }

    public override string ToString()
    {
        return $"{Nom}.{Extension} - {Taille} Ko";
    }
}