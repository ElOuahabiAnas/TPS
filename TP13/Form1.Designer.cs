namespace TP13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nbrTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button calculerButton;
        private System.Windows.Forms.Label lblNbr;
        private System.Windows.Forms.Label lblTotal;

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
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.calculerButton = new System.Windows.Forms.Button();
            this.lblNbr = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Label Nombre de photocopies
            this.lblNbr.AutoSize = true;
            this.lblNbr.Location = new System.Drawing.Point(20, 30);
            this.lblNbr.Name = "lblNbr";
            this.lblNbr.Size = new System.Drawing.Size(150, 20);
            this.lblNbr.Text = "Nombre de photocopies :";
            
            // TextBox Nombre de photocopies
            this.nbrTextBox.Location = new System.Drawing.Point(200, 30);
            this.nbrTextBox.Name = "nbrTextBox";
            this.nbrTextBox.Size = new System.Drawing.Size(150, 27);

            // Label Total à payer
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.Text = "Total à payer :";

            // TextBox Total à payer (lecture seule)
            this.totalTextBox.Location = new System.Drawing.Point(200, 80);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(150, 27);

            // Bouton Calculer
            this.calculerButton.Location = new System.Drawing.Point(130, 130);
            this.calculerButton.Name = "calculerButton";
            this.calculerButton.Size = new System.Drawing.Size(100, 30);
            this.calculerButton.Text = "Calculer";
            this.calculerButton.UseVisualStyleBackColor = true;
            this.calculerButton.Click += new System.EventHandler(this.calculerButton_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblNbr);
            this.Controls.Add(this.nbrTextBox);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.calculerButton);
            this.Name = "Form1";
            this.Text = "Facture Photocopies";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
