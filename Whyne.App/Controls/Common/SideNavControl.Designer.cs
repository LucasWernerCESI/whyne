namespace Whyne.App.Controls.Common
{
    partial class UserSideNavControl
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
            this.SideNavPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // SideNavPanel
            // 
            this.SideNavPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SideNavPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.SideNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SideNavPanel.Name = "SideNavPanel";
            this.SideNavPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SideNavPanel.Size = new System.Drawing.Size(150, 390);
            this.SideNavPanel.TabIndex = 0;
            // 
            // SideNavControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SideNavPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SideNavControl";
            this.Size = new System.Drawing.Size(150, 390);
            this.Load += new System.EventHandler(this.SideNavControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SideNavPanel;
    }
}
