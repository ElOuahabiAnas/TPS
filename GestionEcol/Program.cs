using System;
using System.Windows.Forms;
using Gestion_Ecole;

namespace GestionEcol
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IConnexion connexion = new Connexion("ensat");
            DAOEleve dao = new DAOEleve(connexion);
            Application.Run(new Form1(dao));
        }
    }
}