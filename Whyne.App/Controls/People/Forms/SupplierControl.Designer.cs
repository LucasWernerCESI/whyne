namespace Whyne.App.Controls.People
{
    partial class SupplierControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.SupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationNumberLabel = new System.Windows.Forms.Label();
            this.TaxNumberTextBox = new System.Windows.Forms.TextBox();
            this.TaxNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(662, 311);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(123, 43);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Envoyer";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.Location = new System.Drawing.Point(24, 20);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(274, 27);
            this.SupplierNameLabel.TabIndex = 1;
            this.SupplierNameLabel.Text = "Nom de la société :";
            this.SupplierNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SupplierNameTextBox
            // 
            this.SupplierNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierNameTextBox.Location = new System.Drawing.Point(330, 20);
            this.SupplierNameTextBox.Name = "SupplierNameTextBox";
            this.SupplierNameTextBox.Size = new System.Drawing.Size(455, 27);
            this.SupplierNameTextBox.TabIndex = 2;
            // 
            // RegistrationNumberTextBox
            // 
            this.RegistrationNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationNumberTextBox.Location = new System.Drawing.Point(330, 65);
            this.RegistrationNumberTextBox.Name = "RegistrationNumberTextBox";
            this.RegistrationNumberTextBox.Size = new System.Drawing.Size(455, 27);
            this.RegistrationNumberTextBox.TabIndex = 4;
            // 
            // RegistrationNumberLabel
            // 
            this.RegistrationNumberLabel.Location = new System.Drawing.Point(24, 65);
            this.RegistrationNumberLabel.Name = "RegistrationNumberLabel";
            this.RegistrationNumberLabel.Size = new System.Drawing.Size(274, 27);
            this.RegistrationNumberLabel.TabIndex = 3;
            this.RegistrationNumberLabel.Text = "SIRET :";
            this.RegistrationNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaxNumberTextBox
            // 
            this.TaxNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxNumberTextBox.Location = new System.Drawing.Point(330, 113);
            this.TaxNumberTextBox.Name = "TaxNumberTextBox";
            this.TaxNumberTextBox.Size = new System.Drawing.Size(455, 27);
            this.TaxNumberTextBox.TabIndex = 6;
            // 
            // TaxNumberLabel
            // 
            this.TaxNumberLabel.Location = new System.Drawing.Point(24, 113);
            this.TaxNumberLabel.Name = "TaxNumberLabel";
            this.TaxNumberLabel.Size = new System.Drawing.Size(274, 27);
            this.TaxNumberLabel.TabIndex = 5;
            this.TaxNumberLabel.Text = "Numéro TVA :";
            this.TaxNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SupplierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TaxNumberTextBox);
            this.Controls.Add(this.TaxNumberLabel);
            this.Controls.Add(this.RegistrationNumberTextBox);
            this.Controls.Add(this.RegistrationNumberLabel);
            this.Controls.Add(this.SupplierNameTextBox);
            this.Controls.Add(this.SupplierNameLabel);
            this.Controls.Add(this.SubmitButton);
            this.Name = "SupplierControl";
            this.Size = new System.Drawing.Size(813, 376);
            this.Load += new System.EventHandler(this.SupplierControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.TextBox SupplierNameTextBox;
        private System.Windows.Forms.TextBox RegistrationNumberTextBox;
        private System.Windows.Forms.Label RegistrationNumberLabel;
        private System.Windows.Forms.TextBox TaxNumberTextBox;
        private System.Windows.Forms.Label TaxNumberLabel;
    }
}
