namespace Whyne.App.Controls.People
{
    partial class PeopleControl
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
            this.ContentControl = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // ContentControl
            // 
            this.ContentControl.ColumnCount = 2;
            this.ContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ContentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentControl.Location = new System.Drawing.Point(0, 0);
            this.ContentControl.Margin = new System.Windows.Forms.Padding(0);
            this.ContentControl.Name = "ContentControl";
            this.ContentControl.RowCount = 1;
            this.ContentControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentControl.Size = new System.Drawing.Size(497, 423);
            this.ContentControl.TabIndex = 0;
            // 
            // PeopleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentControl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PeopleControl";
            this.Size = new System.Drawing.Size(497, 423);
            this.Load += new System.EventHandler(this.PeopleControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContentControl;
    }
}
