using System.ComponentModel;

namespace Wookies_arkanoid.Game
{
    partial class Play
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.picPlay1 = new System.Windows.Forms.PictureBox();
            this.picPlay2 = new System.Windows.Forms.PictureBox();
            this.tmrPlay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.picPlay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picPlay2)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlay1
            // 
            this.picPlay1.BackColor = System.Drawing.Color.Transparent;
            this.picPlay1.Location = new System.Drawing.Point(36, 382);
            this.picPlay1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPlay1.Name = "picPlay1";
            this.picPlay1.Size = new System.Drawing.Size(211, 46);
            this.picPlay1.TabIndex = 0;
            this.picPlay1.TabStop = false;
            // 
            // picPlay2
            // 
            this.picPlay2.BackColor = System.Drawing.Color.Transparent;
            this.picPlay2.Location = new System.Drawing.Point(75, 2);
            this.picPlay2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPlay2.Name = "picPlay2";
            this.picPlay2.Size = new System.Drawing.Size(75, 66);
            this.picPlay2.TabIndex = 1;
            this.picPlay2.TabStop = false;
            // 
            // tmrPlay
            // 
            this.tmrPlay.Interval = 20;
            this.tmrPlay.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.picPlay2);
            this.Controls.Add(this.picPlay1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Play";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Play_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Play_MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.picPlay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picPlay2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picPlay1;
        private System.Windows.Forms.PictureBox picPlay2;
        private System.Windows.Forms.Timer tmrPlay;

        #endregion
    }
}