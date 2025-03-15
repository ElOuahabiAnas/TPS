using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TP14
{
    public partial class Form1 : Form
    {
        private List<double> notes = new List<double>();
        private int nombreEtudiants;
        private int indexEtudiant = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void saisirButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(noteTextBox.Text, out double note) && note >= 0 && note <= 20)
            {
                notes.Add(note);
                noteTextBox.Clear();

                if (notes.Count < nombreEtudiants)
                {
                    indexEtudiant++;
                    noteLabel.Text = $"Note de l'étudiant {indexEtudiant}";
                }
                else
                {
                    CalculerStatistiques();
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer une note valide entre 0 et 20.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nbrTextBox.Text, out nombreEtudiants) && nombreEtudiants > 0)
            {
                notes.Clear();
                indexEtudiant = 1;
                noteLabel.Text = "Note de l'étudiant 1";
                noteTextBox.Enabled = true;
                saisirButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide d'étudiants.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalculerStatistiques()
        {
            maxTextBox.Text = notes.Max().ToString("0.00");
            minTextBox.Text = notes.Min().ToString("0.00");
            moyenneTextBox.Text = notes.Average().ToString("0.00");

            noteTextBox.Enabled = false;
            saisirButton.Enabled = false;
        }
    }
}
