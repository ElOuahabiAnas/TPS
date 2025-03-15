using System;
using System.Windows.Forms;

namespace TP13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculerButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nbrTextBox.Text, out int nbrPhotocopies))
            {
                double total = CalculerFacture(nbrPhotocopies);
                totalTextBox.Text = total.ToString("0.00") + " Dhs";
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double CalculerFacture(int nbr)
        {
            double total = 0;
            if (nbr <= 10)
                total = nbr * 0.5;
            else if (nbr <= 30)
                total = (10 * 0.5) + ((nbr - 10) * 0.25);
            else
                total = (10 * 0.5) + (20 * 0.25) + ((nbr - 30) * 0.1);

            return total;
        }
    }
}