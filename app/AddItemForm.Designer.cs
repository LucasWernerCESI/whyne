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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.Titlebox.Size = new System.Drawing.Size(245, 23);
            this.Titlebox.TabIndex = 2;
            this.Titlebox.TextChanged += new System.EventHandler(this.Titlebox_TextChanged);
            // 
            // Descriptionbox
            // 
            this.Descriptionbox.Location = new System.Drawing.Point(139, 97);
            this.Descriptionbox.Multiline = true;
            this.Descriptionbox.Name = "Descriptionbox";
            this.Descriptionbox.Size = new System.Drawing.Size(500, 92);
            this.Descriptionbox.TabIndex = 3;
            // 
            // Famillybox
            // 
            this.Famillybox.Location = new System.Drawing.Point(139, 219);
            this.Famillybox.Name = "Famillybox";
            this.Famillybox.Size = new System.Drawing.Size(245, 23);
            this.Famillybox.TabIndex = 4;
            // 
            // DegreeAlcoolobox
            // 
            this.DegreeAlcoolobox.Location = new System.Drawing.Point(139, 272);
            this.DegreeAlcoolobox.Name = "DegreeAlcoolobox";
            this.DegreeAlcoolobox.Size = new System.Drawing.Size(245, 23);
            this.DegreeAlcoolobox.TabIndex = 5;
            this.DegreeAlcoolobox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Quantitybox
            // 
            this.Quantitybox.Location = new System.Drawing.Point(394, 219);
            this.Quantitybox.Name = "Quantitybox";
            this.Quantitybox.Size = new System.Drawing.Size(245, 23);
            this.Quantitybox.TabIndex = 6;
            this.Quantitybox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Providerbox
            // 
            this.Providerbox.Location = new System.Drawing.Point(139, 327);
            this.Providerbox.Name = "Providerbox";
            this.Providerbox.Size = new System.Drawing.Size(245, 23);
            this.Providerbox.TabIndex = 7;
            this.Providerbox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Pricebox
            // 
            this.Pricebox.Location = new System.Drawing.Point(394, 272);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(245, 23);
            this.Pricebox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Familly";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Degree Alcoolo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Provider";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}