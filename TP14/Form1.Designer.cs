namespace TP14
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nbrTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox moyenneTextBox;
        private System.Windows.Forms.Button saisirButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label nbrLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label moyenneLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nbrTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.moyenneTextBox = new System.Windows.Forms.TextBox();
            this.saisirButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.nbrLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.moyenneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Label Nombre d'Étudiants
            this.nbrLabel.AutoSize = true;
            this.nbrLabel.Location = new System.Drawing.Point(20, 20);
            this.nbrLabel.Text = "Nombre d'étudiants :";

            // TextBox Nombre d'Étudiants
            this.nbrTextBox.Location = new System.Drawing.Point(180, 20);
            this.nbrTextBox.Size = new System.Drawing.Size(100, 27);

            // Bouton Démarrer
            this.startButton.Location = new System.Drawing.Point(300, 20);
            this.startButton.Size = new System.Drawing.Size(80, 27);
            this.startButton.Text = "Démarrer";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);

            // Label Note de l'Étudiant
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(20, 60);
            this.noteLabel.Text = "Note de l'étudiant 1 :";

            // TextBox Note Étudiant
            this.noteTextBox.Location = new System.Drawing.Point(180, 60);
            this.noteTextBox.Size = new System.Drawing.Size(100, 27);
            this.noteTextBox.Enabled = false;

            // Bouton Saisir
            this.saisirButton.Location = new System.Drawing.Point(300, 60);
            this.saisirButton.Size = new System.Drawing.Size(80, 27);
            this.saisirButton.Text = "Saisir";
            this.saisirButton.Enabled = false;
            this.saisirButton.Click += new System.EventHandler(this.saisirButton_Click);

            // Label Max
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(20, 110);
            this.maxLabel.Text = "Max :";

            // TextBox Max
            this.maxTextBox.Location = new System.Drawing.Point(80, 110);
            this.maxTextBox.Size = new System.Drawing.Size(100, 27);
            this.maxTextBox.ReadOnly = true;

            // Label Min
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(190, 110);
            this.minLabel.Text = "Min :";

            // TextBox Min
            this.minTextBox.Location = new System.Drawing.Point(230, 110);
            this.minTextBox.Size = new System.Drawing.Size(100, 27);
            this.minTextBox.ReadOnly = true;

            // Label Moyenne
            this.moyenneLabel.AutoSize = true;
            this.moyenneLabel.Location = new System.Drawing.Point(340, 110);
            this.moyenneLabel.Text = "Moyenne :";

            // TextBox Moyenne
            this.moyenneTextBox.Location = new System.Drawing.Point(420, 110);
            this.moyenneTextBox.Size = new System.Drawing.Size(100, 27);
            this.moyenneTextBox.ReadOnly = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 200);
            this.Controls.Add(this.nbrLabel);
            this.Controls.Add(this.nbrTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.saisirButton);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.moyenneLabel);
            this.Controls.Add(this.moyenneTextBox);
            this.Name = "Form1";
            this.Text = "Gestion des notes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
