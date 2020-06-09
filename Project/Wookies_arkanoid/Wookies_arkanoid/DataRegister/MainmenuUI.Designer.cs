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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonTop10MM = new System.Windows.Forms.PictureBox();
            this.ExitMM = new System.Windows.Forms.PictureBox();
            this.botonPlayMM = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.botonTop10MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ExitMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.botonPlayMM)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.botonTop10MM, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ExitMM, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.botonPlayMM, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 680);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 5);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(100, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // botonTop10MM
            // 
            this.botonTop10MM.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.botonTop10MM.BackColor = System.Drawing.Color.Transparent;
            this.botonTop10MM.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("botonTop10MM.BackgroundImage")));
            this.botonTop10MM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonTop10MM.Location = new System.Drawing.Point(100, 513);
            this.botonTop10MM.Name = "botonTop10MM";
            this.botonTop10MM.Size = new System.Drawing.Size(188, 48);
            this.botonTop10MM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.botonTop10MM.TabIndex = 1;
            this.botonTop10MM.TabStop = false;
            this.botonTop10MM.Click += new System.EventHandler(this.botonTop10MM_Click);
            // 
            // ExitMM
            // 
            this.ExitMM.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitMM.BackColor = System.Drawing.Color.Transparent;
            this.ExitMM.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("ExitMM.BackgroundImage")));
            this.ExitMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitMM.Location = new System.Drawing.Point(682, 513);
            this.ExitMM.Name = "ExitMM";
            this.ExitMM.Size = new System.Drawing.Size(188, 59);
            this.ExitMM.TabIndex = 3;
            this.ExitMM.TabStop = false;
            this.ExitMM.Click += new System.EventHandler(this.ExitMM_Click);
            // 
            // botonPlayMM
            // 
            this.botonPlayMM.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.botonPlayMM.BackColor = System.Drawing.Color.Transparent;
            this.botonPlayMM.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("botonPlayMM.BackgroundImage")));
            this.botonPlayMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonPlayMM.Location = new System.Drawing.Point(391, 513);
            this.botonPlayMM.Name = "botonPlayMM";
            this.botonPlayMM.Size = new System.Drawing.Size(188, 86);
            this.botonPlayMM.TabIndex = 2;
            this.botonPlayMM.TabStop = false;
            this.botonPlayMM.Click += new System.EventHandler(this.botonPlayMM_Click);
            // 
            // MainmenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainmenuUI";
            this.Size = new System.Drawing.Size(974, 680);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.botonTop10MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ExitMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.botonPlayMM)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox botonPlayMM;
        private System.Windows.Forms.PictureBox botonTop10MM;
        private System.Windows.Forms.PictureBox ExitMM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}