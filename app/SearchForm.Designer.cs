namespace Whyne.App
{
    partial class SearchForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filterbox2 = new System.Windows.Forms.TextBox();
            this.Filterbox1 = new System.Windows.Forms.TextBox();
            this.Searchbt = new System.Windows.Forms.Button();
            this.Searchlist = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Filterbox2);
            this.panel1.Controls.Add(this.Filterbox1);
            this.panel1.Controls.Add(this.Searchbt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // Filterbox2
            // 
            this.Filterbox2.Location = new System.Drawing.Point(353, 37);
            this.Filterbox2.Name = "Filterbox2";
            this.Filterbox2.Size = new System.Drawing.Size(200, 23);
            this.Filterbox2.TabIndex = 2;
            // 
            // Filterbox1
            // 
            this.Filterbox1.Location = new System.Drawing.Point(106, 36);
            this.Filterbox1.Name = "Filterbox1";
            this.Filterbox1.Size = new System.Drawing.Size(200, 23);
            this.Filterbox1.TabIndex = 1;
            this.Filterbox1.TextChanged += new System.EventHandler(this.Filterbox1_TextChanged);
            // 
            // Searchbt
            // 
            this.Searchbt.Location = new System.Drawing.Point(592, 36);
            this.Searchbt.Name = "Searchbt";
            this.Searchbt.Size = new System.Drawing.Size(100, 23);
            this.Searchbt.TabIndex = 0;
            this.Searchbt.Text = "Search";
            this.Searchbt.UseVisualStyleBackColor = true;
            this.Searchbt.Click += new System.EventHandler(this.Searchbt_Click);
            // 
            // Searchlist
            // 
            this.Searchlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Searchlist.FormattingEnabled = true;
            this.Searchlist.ItemHeight = 15;
            this.Searchlist.Items.AddRange(new object[] {
            "test"});
            this.Searchlist.Location = new System.Drawing.Point(0, 100);
            this.Searchlist.Name = "Searchlist";
            this.Searchlist.Size = new System.Drawing.Size(800, 350);
            this.Searchlist.TabIndex = 1;
            this.Searchlist.SelectedIndexChanged += new System.EventHandler(this.Searchlist_SelectedIndexChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Searchlist);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Filterbox2;
        private System.Windows.Forms.TextBox Filterbox1;
        private System.Windows.Forms.Button Searchbt;
        private System.Windows.Forms.ListBox Searchlist;
    }
}