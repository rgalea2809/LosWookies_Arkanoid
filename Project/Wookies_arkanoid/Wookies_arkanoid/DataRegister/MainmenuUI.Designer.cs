using System.ComponentModel;

namespace Wookies_arkanoid
{
    partial class MainmenuUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainmenuUI));
            this.tlpMainMenuUI = new System.Windows.Forms.TableLayoutPanel();
            this.picTitle4 = new System.Windows.Forms.PictureBox();
            this.picScoresMM1 = new System.Windows.Forms.PictureBox();
            this.picExitMM3 = new System.Windows.Forms.PictureBox();
            this.picPlayMM2 = new System.Windows.Forms.PictureBox();
            this.tlpMainMenuUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picTitle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picScoresMM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picExitMM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picPlayMM2)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainMenuUI
            // 
            this.tlpMainMenuUI.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tlpMainMenuUI.BackgroundImage")));
            this.tlpMainMenuUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpMainMenuUI.ColumnCount = 7;
            this.tlpMainMenuUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainMenuUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainMenuUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainMenuUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainMenuUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainMenuUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainMenuUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainMenuUI.Controls.Add(this.picTitle4, 1, 1);
            this.tlpMainMenuUI.Controls.Add(this.picScoresMM1, 1, 3);
            this.tlpMainMenuUI.Controls.Add(this.picExitMM3, 5, 3);
            this.tlpMainMenuUI.Controls.Add(this.picPlayMM2, 3, 3);
            this.tlpMainMenuUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainMenuUI.Location = new System.Drawing.Point(0, 0);
            this.tlpMainMenuUI.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMainMenuUI.Name = "tlpMainMenuUI";
            this.tlpMainMenuUI.RowCount = 4;
            this.tlpMainMenuUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMainMenuUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainMenuUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMainMenuUI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMainMenuUI.Size = new System.Drawing.Size(730, 552);
            this.tlpMainMenuUI.TabIndex = 0;
            // 
            // picTitle4
            // 
            this.picTitle4.BackColor = System.Drawing.Color.Transparent;
            this.picTitle4.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("picTitle4.BackgroundImage")));
            this.picTitle4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tlpMainMenuUI.SetColumnSpan(this.picTitle4, 5);
            this.picTitle4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTitle4.Location = new System.Drawing.Point(75, 84);
            this.picTitle4.Margin = new System.Windows.Forms.Padding(2);
            this.picTitle4.Name = "picTitle4";
            this.picTitle4.Size = new System.Drawing.Size(580, 106);
            this.picTitle4.TabIndex = 0;
            this.picTitle4.TabStop = false;
            // 
            // picScoresMM1
            // 
            this.picScoresMM1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picScoresMM1.BackColor = System.Drawing.Color.Transparent;
            this.picScoresMM1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("picScoresMM1.BackgroundImage")));
            this.picScoresMM1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picScoresMM1.Location = new System.Drawing.Point(75, 414);
            this.picScoresMM1.Margin = new System.Windows.Forms.Padding(2);
            this.picScoresMM1.Name = "picScoresMM1";
            this.picScoresMM1.Size = new System.Drawing.Size(142, 48);
            this.picScoresMM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picScoresMM1.TabIndex = 1;
            this.picScoresMM1.TabStop = false;
            this.picScoresMM1.Click += new System.EventHandler(this.botonTop10MM_Click);
            // 
            // picExitMM3
            // 
            this.picExitMM3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picExitMM3.BackColor = System.Drawing.Color.Transparent;
            this.picExitMM3.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("picExitMM3.BackgroundImage")));
            this.picExitMM3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExitMM3.Location = new System.Drawing.Point(513, 414);
            this.picExitMM3.Margin = new System.Windows.Forms.Padding(2);
            this.picExitMM3.Name = "picExitMM3";
            this.picExitMM3.Size = new System.Drawing.Size(142, 48);
            this.picExitMM3.TabIndex = 3;
            this.picExitMM3.TabStop = false;
            this.picExitMM3.Click += new System.EventHandler(this.ExitMM_Click);
            // 
            // picPlayMM2
            // 
            this.picPlayMM2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picPlayMM2.BackColor = System.Drawing.Color.Transparent;
            this.picPlayMM2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("picPlayMM2.BackgroundImage")));
            this.picPlayMM2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlayMM2.Location = new System.Drawing.Point(294, 414);
            this.picPlayMM2.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayMM2.Name = "picPlayMM2";
            this.picPlayMM2.Size = new System.Drawing.Size(142, 70);
            this.picPlayMM2.TabIndex = 2;
            this.picPlayMM2.TabStop = false;
            this.picPlayMM2.Click += new System.EventHandler(this.botonPlayMM_Click);
            // 
            // MainmenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMainMenuUI);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainmenuUI";
            this.Size = new System.Drawing.Size(730, 552);
            this.tlpMainMenuUI.ResumeLayout(false);
            this.tlpMainMenuUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picTitle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picScoresMM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picExitMM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picPlayMM2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picExitMM3;
        private System.Windows.Forms.PictureBox picPlayMM2;
        private System.Windows.Forms.PictureBox picScoresMM1;
        private System.Windows.Forms.PictureBox picTitle4;
        private System.Windows.Forms.TableLayoutPanel tlpMainMenuUI;

        #endregion
    }
}