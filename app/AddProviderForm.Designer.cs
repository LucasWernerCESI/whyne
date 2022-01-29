namespace Whyne.App
{
    partial class AddProviderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Confirmbt = new System.Windows.Forms.Button();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Locationbox = new System.Windows.Forms.TextBox();
            this.Productbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un Forunisseur";
            // 
            // Confirmbt
            // 
            this.Confirmbt.Location = new System.Drawing.Point(713, 415);
            this.Confirmbt.Name = "Confirmbt";
            this.Confirmbt.Size = new System.Drawing.Size(75, 23);
            this.Confirmbt.TabIndex = 1;
            this.Confirmbt.Text = "Confirmer";
            this.Confirmbt.UseVisualStyleBackColor = true;
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(157, 78);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(250, 23);
            this.Namebox.TabIndex = 2;
            // 
            // Locationbox
            // 
            this.Locationbox.Location = new System.Drawing.Point(157, 150);
            this.Locationbox.Name = "Locationbox";
            this.Locationbox.Size = new System.Drawing.Size(500, 23);
            this.Locationbox.TabIndex = 3;
            // 
            // Productbox
            // 
            this.Productbox.Location = new System.Drawing.Point(157, 222);
            this.Productbox.Multiline = true;
            this.Productbox.Name = "Productbox";
            this.Productbox.Size = new System.Drawing.Size(500, 123);
            this.Productbox.TabIndex = 4;
            this.Productbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product";
            // 
            // AddProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Productbox);
            this.Controls.Add(this.Locationbox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.Confirmbt);
            this.Controls.Add(this.label1);
            this.Name = "AddProviderForm";
            this.Text = "AddProviderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirmbt;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox Locationbox;
        private System.Windows.Forms.TextBox Productbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}