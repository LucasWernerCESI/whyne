namespace Whyne.App.Controls.Common.Items
{
    partial class SideNavItem
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
            this.ItemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemLabel
            // 
            this.ItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItemLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ItemLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemLabel.Location = new System.Drawing.Point(0, 0);
            this.ItemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(150, 75);
            this.ItemLabel.TabIndex = 0;
            this.ItemLabel.Text = "label1";
            this.ItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideNavItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.ItemLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.Name = "SideNavItem";
            this.Size = new System.Drawing.Size(150, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ItemLabel;
    }
}
