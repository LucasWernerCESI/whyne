namespace Whyne.App.Controls
{
    partial class HomeControl
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
            this.HomeTitle = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeTitle
            // 
            this.HomeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeTitle.Location = new System.Drawing.Point(0, 261);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(986, 31);
            this.HomeTitle.TabIndex = 0;
            this.HomeTitle.Text = "Bienvenue dans votre espace personnel";
            this.HomeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(0, 333);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(986, 25);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "userName";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(0, 372);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(986, 25);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "email";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(0, 411);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(986, 25);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "phoneNumber";
            this.PhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.HomeTitle);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(986, 659);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
    }
}
