using System.ComponentModel;

namespace Wookies_arkanoid.Vista
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpSignup1 = new System.Windows.Forms.GroupBox();
            this.bttnBackSignup3 = new System.Windows.Forms.Button();
            this.bttnExitSignup2 = new System.Windows.Forms.Button();
            this.bttnSignup1 = new System.Windows.Forms.Button();
            this.txtConfirmSignup3 = new System.Windows.Forms.TextBox();
            this.lblConfirmSignup3 = new System.Windows.Forms.Label();
            this.txtPasswordSignup2 = new System.Windows.Forms.TextBox();
            this.lblPasswordSignup2 = new System.Windows.Forms.Label();
            this.txtUserSignup1 = new System.Windows.Forms.TextBox();
            this.lblUserSignup1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSignup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.grpSignup1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 490F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpSignup1
            // 
            this.grpSignup1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSignup1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpSignup1.BackColor = System.Drawing.Color.Transparent;
            this.grpSignup1.Controls.Add(this.bttnBackSignup3);
            this.grpSignup1.Controls.Add(this.bttnExitSignup2);
            this.grpSignup1.Controls.Add(this.bttnSignup1);
            this.grpSignup1.Controls.Add(this.txtConfirmSignup3);
            this.grpSignup1.Controls.Add(this.lblConfirmSignup3);
            this.grpSignup1.Controls.Add(this.txtPasswordSignup2);
            this.grpSignup1.Controls.Add(this.lblPasswordSignup2);
            this.grpSignup1.Controls.Add(this.txtUserSignup1);
            this.grpSignup1.Controls.Add(this.lblUserSignup1);
            this.grpSignup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpSignup1.ForeColor = System.Drawing.Color.White;
            this.grpSignup1.Location = new System.Drawing.Point(76, 48);
            this.grpSignup1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSignup1.Name = "grpSignup1";
            this.grpSignup1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSignup1.Size = new System.Drawing.Size(807, 394);
            this.grpSignup1.TabIndex = 0;
            this.grpSignup1.TabStop = false;
            this.grpSignup1.Text = "SIGN UP";
            // 
            // bttnBackSignup3
            // 
            this.bttnBackSignup3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bttnBackSignup3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnBackSignup3.Location = new System.Drawing.Point(85, 302);
            this.bttnBackSignup3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnBackSignup3.Name = "bttnBackSignup3";
            this.bttnBackSignup3.Size = new System.Drawing.Size(152, 33);
            this.bttnBackSignup3.TabIndex = 8;
            this.bttnBackSignup3.Text = "<<BACK";
            this.bttnBackSignup3.UseVisualStyleBackColor = false;
            this.bttnBackSignup3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnExitSignup2
            // 
            this.bttnExitSignup2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bttnExitSignup2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnExitSignup2.Location = new System.Drawing.Point(571, 302);
            this.bttnExitSignup2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnExitSignup2.Name = "bttnExitSignup2";
            this.bttnExitSignup2.Size = new System.Drawing.Size(139, 33);
            this.bttnExitSignup2.TabIndex = 7;
            this.bttnExitSignup2.Text = "EXIT";
            this.bttnExitSignup2.UseVisualStyleBackColor = false;
            this.bttnExitSignup2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnSignup1
            // 
            this.bttnSignup1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bttnSignup1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnSignup1.Location = new System.Drawing.Point(316, 257);
            this.bttnSignup1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnSignup1.Name = "bttnSignup1";
            this.bttnSignup1.Size = new System.Drawing.Size(139, 39);
            this.bttnSignup1.TabIndex = 6;
            this.bttnSignup1.Text = "SIGN UP";
            this.bttnSignup1.UseVisualStyleBackColor = false;
            this.bttnSignup1.Click += new System.EventHandler(this.signUp_Click);
            // 
            // txtConfirmSignup3
            // 
            this.txtConfirmSignup3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtConfirmSignup3.Location = new System.Drawing.Point(357, 192);
            this.txtConfirmSignup3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmSignup3.Name = "txtConfirmSignup3";
            this.txtConfirmSignup3.Size = new System.Drawing.Size(312, 46);
            this.txtConfirmSignup3.TabIndex = 5;
            // 
            // lblConfirmSignup3
            // 
            this.lblConfirmSignup3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblConfirmSignup3.Location = new System.Drawing.Point(20, 194);
            this.lblConfirmSignup3.Name = "lblConfirmSignup3";
            this.lblConfirmSignup3.Size = new System.Drawing.Size(235, 25);
            this.lblConfirmSignup3.TabIndex = 4;
            this.lblConfirmSignup3.Text = "CONFIRM PASSWORD:";
            // 
            // txtPasswordSignup2
            // 
            this.txtPasswordSignup2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPasswordSignup2.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordSignup2.Location = new System.Drawing.Point(357, 137);
            this.txtPasswordSignup2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordSignup2.Name = "txtPasswordSignup2";
            this.txtPasswordSignup2.Size = new System.Drawing.Size(312, 46);
            this.txtPasswordSignup2.TabIndex = 3;
            // 
            // lblPasswordSignup2
            // 
            this.lblPasswordSignup2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPasswordSignup2.Location = new System.Drawing.Point(99, 137);
            this.lblPasswordSignup2.Name = "lblPasswordSignup2";
            this.lblPasswordSignup2.Size = new System.Drawing.Size(140, 30);
            this.lblPasswordSignup2.TabIndex = 2;
            this.lblPasswordSignup2.Text = "PASSWORD:";
            // 
            // txtUserSignup1
            // 
            this.txtUserSignup1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUserSignup1.Location = new System.Drawing.Point(357, 82);
            this.txtUserSignup1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserSignup1.Name = "txtUserSignup1";
            this.txtUserSignup1.Size = new System.Drawing.Size(312, 46);
            this.txtUserSignup1.TabIndex = 1;
            // 
            // lblUserSignup1
            // 
            this.lblUserSignup1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUserSignup1.Location = new System.Drawing.Point(63, 85);
            this.lblUserSignup1.Name = "lblUserSignup1";
            this.lblUserSignup1.Size = new System.Drawing.Size(191, 34);
            this.lblUserSignup1.TabIndex = 0;
            this.lblUserSignup1.Text = "USER NICKNAME:";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Signin";
            this.Text = "Signin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpSignup1.ResumeLayout(false);
            this.grpSignup1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnBackSignup3;
        private System.Windows.Forms.Button bttnExitSignup2;
        private System.Windows.Forms.Button bttnSignup1;
        private System.Windows.Forms.GroupBox grpSignup1;
        private System.Windows.Forms.Label lblConfirmSignup3;
        private System.Windows.Forms.Label lblPasswordSignup2;
        private System.Windows.Forms.Label lblUserSignup1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtConfirmSignup3;
        private System.Windows.Forms.TextBox txtPasswordSignup2;
        private System.Windows.Forms.TextBox txtUserSignup1;

        #endregion
    }
}