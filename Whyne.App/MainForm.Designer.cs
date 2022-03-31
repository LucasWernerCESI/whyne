
namespace Whyne.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginControlLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainControlLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // LoginControlLayoutPanel
            // 
            this.LoginControlLayoutPanel.ColumnCount = 1;
            this.LoginControlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginControlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginControlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginControlLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.LoginControlLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginControlLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LoginControlLayoutPanel.Name = "LoginControlLayoutPanel";
            this.LoginControlLayoutPanel.RowCount = 1;
            this.LoginControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LoginControlLayoutPanel.Size = new System.Drawing.Size(720, 396);
            this.LoginControlLayoutPanel.TabIndex = 0;
            this.LoginControlLayoutPanel.Visible = false;
            // 
            // MainControlLayoutPanel
            // 
            this.MainControlLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainControlLayoutPanel.ColumnCount = 1;
            this.MainControlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainControlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControlLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.MainControlLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainControlLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainControlLayoutPanel.Name = "MainControlLayoutPanel";
            this.MainControlLayoutPanel.RowCount = 2;
            this.MainControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.MainControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainControlLayoutPanel.Size = new System.Drawing.Size(720, 396);
            this.MainControlLayoutPanel.TabIndex = 1;
            this.MainControlLayoutPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(720, 396);
            this.Controls.Add(this.MainControlLayoutPanel);
            this.Controls.Add(this.LoginControlLayoutPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "Whyne";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LoginControlLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel MainControlLayoutPanel;
    }
}

