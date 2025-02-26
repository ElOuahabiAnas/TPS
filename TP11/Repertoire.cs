using System;

public class Repertoire
{
    private string Nom;
    private int NbrFichiers;
    private Fichier[] fichiers;
    private const int MaxFichiers = 30;

    public Repertoire(string nom)
    {
        Nom = nom;
        fichiers = new Fichier[MaxFichiers];
        NbrFichiers = 0;
    }

    public string nom
    {
        get { return Nom; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                Nom = value;
            else
                throw new ArgumentException("Le nom du répertoire ne peut pas être vide.");
        }
    }

    public int nbrFichiers
    {
        get { return NbrFichiers; }
    }

    public void Afficher()
    {
        Console.WriteLine($"Répertoire : {Nom}");
        if (NbrFichiers == 0)
        {
            Console.WriteLine("Aucun fichier dans le répertoire.");
            return;
        }

        for (int i = 0; i < NbrFichiers; i++)
        {
            Console.WriteLine($"{i + 1}. {fichiers[i]}");
        }
    }

    public int Rechercher(string nom)
    {
        for (int i = 0; i < NbrFichiers; i++)
        {
            if (fichiers[i].nom.Equals(nom, StringComparison.OrdinalIgnoreCase))
                return i;
        }
        return -1;
    }

    public void Ajouter(Fichier fichier)
    {
        if (NbrFichiers < MaxFichiers)
        {
            fichiers[NbrFichiers++] = fichier;
            Console.WriteLine("Fichier ajouté avec succès.");
        }
        else
        {
            Console.WriteLine("Le répertoire est plein.");
        }
    }

    public void Supprimer(string nom)
    {
        int index = Rechercher(nom);
        if (index != -1)
        {
            for (int i = index; i < NbrFichiers - 1; i++)
            {
                fichiers[i] = fichiers[i + 1];
            }
            fichiers[--NbrFichiers] = null;
            Console.WriteLine("Fichier supprimé avec succès.");
        }
        else
        {
            Console.WriteLine("Fichier introuvable.");
        }
    }

    public void Renommer(string nomActuel, string nouveauNom)
    {
        int index = Rechercher(nomActuel);
        if (index != -1)
        {
            fichiers[index].nom = nouveauNom;
            Console.WriteLine("Fichier renommé avec succès.");
        }
        else
        {
            Console.WriteLine("Fichier introuvable.");
        }
    }

    public void ModifierTaille(string nom, float nouvelleTaille)
    {
        int index = Rechercher(nom);
        if (index != -1)
        {
            fichiers[index].taille = nouvelleTaille;
            Console.WriteLine("Taille modifiée avec succès.");
        }
        else
        {
            Console.WriteLine("Fichier introuvable.");
        }
    }

    public void RechercherPdf()
    {
        Console.WriteLine("Fichiers PDF dans le répertoire:");
        bool found = false;
        for (int i = 0; i < NbrFichiers; i++)
        {
            if (fichiers[i].extension.Equals("pdf", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(fichiers[i]);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Aucun fichier PDF trouvé.");
        }
    }

    public float GetTaille()
    {
        float tailleTotal = 0;
        for (int i = 0; i < NbrFichiers; i++)
        {
            tailleTotal += fichiers[i].taille;
        }
        return tailleTotal / 1024; // Conversion en Mo
    }
}
