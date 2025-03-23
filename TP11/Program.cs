using System;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        Fichier f1 = new Fichier("tp1", "pdf", 20);
        Fichier f2 = new Fichier("tp2", "pdf", 25);
        Fichier f3 = new Fichier("tp3", "word", 55);
        Fichier f4 = null;
        Repertoire r1 = new Repertoire("tps");
        r1.Ajouter(f1);
        r1.Ajouter(f2);
        r1.Ajouter(f4);
        r1.Ajouter(f3);
        r1.Afficher();
        r1.Renommer("tp1" , "leTP1");
        r1.Afficher();
        r1.Supprimer("tp2");
        r1.Afficher();
        
    }
}
