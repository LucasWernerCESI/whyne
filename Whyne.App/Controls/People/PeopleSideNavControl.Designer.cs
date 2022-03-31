namespace Whyne.App.Controls.People
{
    partial class PeopleSideNavControl
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
            this.SupplierButton = new System.Windows.Forms.Button();
            this.DistributorButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SupplierButton
            // 
            this.SupplierButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SupplierButton.Location = new System.Drawing.Point(3, 3);
            this.SupplierButton.Name = "SupplierButton";
            this.SupplierButton.Size = new System.Drawing.Size(144, 30);
            this.SupplierButton.TabIndex = 0;
            this.SupplierButton.Text = "Fournisseurs";
            this.SupplierButton.UseVisualStyleBackColor = true;
            this.SupplierButton.Click += new System.EventHandler(this.SupplierButton_Click);
            // 
            // DistributorButton
            // 
            this.DistributorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DistributorButton.Location = new System.Drawing.Point(3, 39);
            this.DistributorButton.Name = "DistributorButton";
            this.DistributorButton.Size = new System.Drawing.Size(144, 30);
            this.DistributorButton.TabIndex = 1;
            this.DistributorButton.Text = "Transporteurs";
            this.DistributorButton.UseVisualStyleBackColor = true;
            // 
            // CustomerButton
            // 
            this.CustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomerButton.Location = new System.Drawing.Point(3, 75);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(144, 30);
            this.CustomerButton.TabIndex = 2;
            this.CustomerButton.Text = "Clients";
            this.CustomerButton.UseVisualStyleBackColor = true;
            // 
            // PeopleSideNavControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.DistributorButton);
            this.Controls.Add(this.SupplierButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PeopleSideNavControl";
            this.Size = new System.Drawing.Size(150, 414);
            this.Load += new System.EventHandler(this.PeopleSideNavControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SupplierButton;
        private System.Windows.Forms.Button DistributorButton;
        private System.Windows.Forms.Button CustomerButton;
    }
}
