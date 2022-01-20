namespace Whyne.App
{
    partial class AddItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Confirmbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Titlebox = new System.Windows.Forms.TextBox();
            this.Descriptionbox = new System.Windows.Forms.TextBox();
            this.Famillybox = new System.Windows.Forms.TextBox();
            this.DegreeAlcoolobox = new System.Windows.Forms.TextBox();
            this.Quantitybox = new System.Windows.Forms.TextBox();
            this.Providerbox = new System.Windows.Forms.TextBox();
            this.Pricebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Confirmbt
            // 
            this.Confirmbt.Location = new System.Drawing.Point(663, 415);
            this.Confirmbt.Name = "Confirmbt";
            this.Confirmbt.Size = new System.Drawing.Size(125, 23);
            this.Confirmbt.TabIndex = 0;
            this.Confirmbt.Text = "Confirmer";
            this.Confirmbt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajouter un Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Titlebox
            // 
            this.Titlebox.Location = new System.Drawing.Point(144, 44);
            this.Titlebox.Name = "Titlebox";
            this.Titlebox.Size = new System.Drawing.Size(250, 23);
            this.Titlebox.TabIndex = 2;
            this.Titlebox.TextChanged += new System.EventHandler(this.Titlebox_TextChanged);
            // 
            // Descriptionbox
            // 
            this.Descriptionbox.Location = new System.Drawing.Point(144, 89);
            this.Descriptionbox.Multiline = true;
            this.Descriptionbox.Name = "Descriptionbox";
            this.Descriptionbox.Size = new System.Drawing.Size(500, 92);
            this.Descriptionbox.TabIndex = 3;
            // 
            // Famillybox
            // 
            this.Famillybox.Location = new System.Drawing.Point(144, 250);
            this.Famillybox.Name = "Famillybox";
            this.Famillybox.Size = new System.Drawing.Size(250, 23);
            this.Famillybox.TabIndex = 4;
            // 
            // DegreeAlcoolobox
            // 
            this.DegreeAlcoolobox.Location = new System.Drawing.Point(144, 203);
            this.DegreeAlcoolobox.Name = "DegreeAlcoolobox";
            this.DegreeAlcoolobox.Size = new System.Drawing.Size(250, 23);
            this.DegreeAlcoolobox.TabIndex = 5;
            this.DegreeAlcoolobox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Quantitybox
            // 
            this.Quantitybox.Location = new System.Drawing.Point(144, 291);
            this.Quantitybox.Name = "Quantitybox";
            this.Quantitybox.Size = new System.Drawing.Size(250, 23);
            this.Quantitybox.TabIndex = 6;
            this.Quantitybox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Providerbox
            // 
            this.Providerbox.Location = new System.Drawing.Point(144, 335);
            this.Providerbox.Name = "Providerbox";
            this.Providerbox.Size = new System.Drawing.Size(250, 23);
            this.Providerbox.TabIndex = 7;
            this.Providerbox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Pricebox
            // 
            this.Pricebox.Location = new System.Drawing.Point(144, 387);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(250, 23);
            this.Pricebox.TabIndex = 8;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pricebox);
            this.Controls.Add(this.Providerbox);
            this.Controls.Add(this.Quantitybox);
            this.Controls.Add(this.DegreeAlcoolobox);
            this.Controls.Add(this.Famillybox);
            this.Controls.Add(this.Descriptionbox);
            this.Controls.Add(this.Titlebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirmbt);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirmbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Titlebox;
        private System.Windows.Forms.TextBox Descriptionbox;
        private System.Windows.Forms.TextBox Famillybox;
        private System.Windows.Forms.TextBox DegreeAlcoolobox;
        private System.Windows.Forms.TextBox Quantitybox;
        private System.Windows.Forms.TextBox Providerbox;
        private System.Windows.Forms.TextBox Pricebox;
    }
}