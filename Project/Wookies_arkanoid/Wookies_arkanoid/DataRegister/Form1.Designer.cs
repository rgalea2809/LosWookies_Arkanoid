namespace Wookies_arkanoid
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlpMainMenu1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenuUI1 = new Wookies_arkanoid.MainmenuUI();
            this.tlpMainMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainMenu1
            // 
            this.tlpMainMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpMainMenu1.ColumnCount = 1;
            this.tlpMainMenu1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainMenu1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMainMenu1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMainMenu1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMainMenu1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMainMenu1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMainMenu1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpMainMenu1.Controls.Add(this.MainMenuUI1, 0, 0);
            this.tlpMainMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainMenu1.Location = new System.Drawing.Point(0, 0);
            this.tlpMainMenu1.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMainMenu1.Name = "tlpMainMenu1";
            this.tlpMainMenu1.RowCount = 1;
            this.tlpMainMenu1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainMenu1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 521F));
            this.tlpMainMenu1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 521F));
            this.tlpMainMenu1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 521F));
            this.tlpMainMenu1.Size = new System.Drawing.Size(680, 521);
            this.tlpMainMenu1.TabIndex = 0;
            // 
            // MainMenuUI1
            // 
            this.MainMenuUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuUI1.Location = new System.Drawing.Point(2, 2);
            this.MainMenuUI1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainMenuUI1.Name = "MainMenuUI1";
            this.MainMenuUI1.Size = new System.Drawing.Size(676, 517);
            this.MainMenuUI1.TabIndex = 0;
            this.MainMenuUI1.VisibleChanged += new System.EventHandler(this.mainmenuUI1_VisibleChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(680, 521);
            this.Controls.Add(this.tlpMainMenu1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpMainMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Wookies_arkanoid.MainmenuUI MainMenuUI1;
        private System.Windows.Forms.TableLayoutPanel tlpMainMenu1;

        #endregion
    }
}