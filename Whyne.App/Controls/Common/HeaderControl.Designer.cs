namespace Whyne.App.Controls.Common
{
    partial class HeaderControl
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.PeopleButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(13, 22);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(140, 30);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Accueil";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PeopleButton
            // 
            this.PeopleButton.Location = new System.Drawing.Point(148, 22);
            this.PeopleButton.Name = "PeopleButton";
            this.PeopleButton.Size = new System.Drawing.Size(140, 30);
            this.PeopleButton.TabIndex = 1;
            this.PeopleButton.Text = "Tiers";
            this.PeopleButton.UseVisualStyleBackColor = true;
            this.PeopleButton.Click += new System.EventHandler(this.PeopleButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(283, 22);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(140, 30);
            this.ProductsButton.TabIndex = 2;
            this.ProductsButton.Text = "Catalogue";
            this.ProductsButton.UseVisualStyleBackColor = true;
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(418, 22);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(140, 30);
            this.InventoryButton.TabIndex = 3;
            this.InventoryButton.Text = "Inventaire";
            this.InventoryButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Location = new System.Drawing.Point(745, 22);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(140, 30);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Déconnexion";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // HeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.PeopleButton);
            this.Controls.Add(this.HomeButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HeaderControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(898, 75);
            this.Load += new System.EventHandler(this.HeaderControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button PeopleButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}
