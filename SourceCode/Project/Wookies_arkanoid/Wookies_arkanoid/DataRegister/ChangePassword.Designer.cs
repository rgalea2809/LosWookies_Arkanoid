using System.ComponentModel;

namespace Wookies_arkanoid.Vista
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.tlpChangePassword1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpChangePassword1 = new System.Windows.Forms.GroupBox();
            this.cmbUser1 = new System.Windows.Forms.ComboBox();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.changepwdBTN = new System.Windows.Forms.Button();
            this.bttnBack1 = new System.Windows.Forms.Button();
            this.txtCNewPassword3 = new System.Windows.Forms.TextBox();
            this.lblCNewPassword4 = new System.Windows.Forms.Label();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.lblNewPassword3 = new System.Windows.Forms.Label();
            this.txtOldPassword1 = new System.Windows.Forms.TextBox();
            this.lblOldPassword2 = new System.Windows.Forms.Label();
            this.tlpChangePassword1.SuspendLayout();
            this.grpChangePassword1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpChangePassword1
            // 
            this.tlpChangePassword1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpChangePassword1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tlpChangePassword1.BackgroundImage")));
            this.tlpChangePassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpChangePassword1.ColumnCount = 1;
            this.tlpChangePassword1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChangePassword1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpChangePassword1.Controls.Add(this.grpChangePassword1, 0, 0);
            this.tlpChangePassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChangePassword1.Location = new System.Drawing.Point(0, 0);
            this.tlpChangePassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpChangePassword1.Name = "tlpChangePassword1";
            this.tlpChangePassword1.RowCount = 1;
            this.tlpChangePassword1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChangePassword1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 604F));
            this.tlpChangePassword1.Size = new System.Drawing.Size(1075, 604);
            this.tlpChangePassword1.TabIndex = 0;
            // 
            // grpChangePassword1
            // 
            this.grpChangePassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpChangePassword1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpChangePassword1.BackColor = System.Drawing.Color.Transparent;
            this.grpChangePassword1.Controls.Add(this.cmbUser1);
            this.grpChangePassword1.Controls.Add(this.lblUser1);
            this.grpChangePassword1.Controls.Add(this.changepwdBTN);
            this.grpChangePassword1.Controls.Add(this.bttnBack1);
            this.grpChangePassword1.Controls.Add(this.txtCNewPassword3);
            this.grpChangePassword1.Controls.Add(this.lblCNewPassword4);
            this.grpChangePassword1.Controls.Add(this.txtNewPassword2);
            this.grpChangePassword1.Controls.Add(this.lblNewPassword3);
            this.grpChangePassword1.Controls.Add(this.txtOldPassword1);
            this.grpChangePassword1.Controls.Add(this.lblOldPassword2);
            this.grpChangePassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpChangePassword1.ForeColor = System.Drawing.Color.White;
            this.grpChangePassword1.Location = new System.Drawing.Point(171, 39);
            this.grpChangePassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangePassword1.Name = "grpChangePassword1";
            this.grpChangePassword1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChangePassword1.Size = new System.Drawing.Size(732, 526);
            this.grpChangePassword1.TabIndex = 0;
            this.grpChangePassword1.TabStop = false;
            this.grpChangePassword1.Text = "CHANGE PASSWORD";
            // 
            // cmbUser1
            // 
            this.cmbUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbUser1.FormattingEnabled = true;
            this.cmbUser1.Location = new System.Drawing.Point(352, 128);
            this.cmbUser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUser1.Name = "cmbUser1";
            this.cmbUser1.Size = new System.Drawing.Size(311, 46);
            this.cmbUser1.TabIndex = 9;
            // 
            // lblUser1
            // 
            this.lblUser1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUser1.Location = new System.Drawing.Point(143, 134);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(179, 21);
            this.lblUser1.TabIndex = 8;
            this.lblUser1.Text = "USERNAME:";
            // 
            // changepwdBTN
            // 
            this.changepwdBTN.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.changepwdBTN.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.changepwdBTN.Location = new System.Drawing.Point(411, 418);
            this.changepwdBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changepwdBTN.Name = "changepwdBTN";
            this.changepwdBTN.Size = new System.Drawing.Size(251, 42);
            this.changepwdBTN.TabIndex = 7;
            this.changepwdBTN.Text = "CHANGE PASSWORD";
            this.changepwdBTN.UseVisualStyleBackColor = false;
            this.changepwdBTN.Click += new System.EventHandler(this.changepwdBTN_Click);
            // 
            // bttnBack1
            // 
            this.bttnBack1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bttnBack1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnBack1.Location = new System.Drawing.Point(104, 418);
            this.bttnBack1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnBack1.Name = "bttnBack1";
            this.bttnBack1.Size = new System.Drawing.Size(147, 42);
            this.bttnBack1.TabIndex = 6;
            this.bttnBack1.Text = "<<BACK";
            this.bttnBack1.UseVisualStyleBackColor = false;
            this.bttnBack1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCNewPassword3
            // 
            this.txtCNewPassword3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCNewPassword3.Location = new System.Drawing.Point(352, 338);
            this.txtCNewPassword3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCNewPassword3.Name = "txtCNewPassword3";
            this.txtCNewPassword3.Size = new System.Drawing.Size(311, 46);
            this.txtCNewPassword3.TabIndex = 5;
            // 
            // lblCNewPassword4
            // 
            this.lblCNewPassword4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCNewPassword4.Location = new System.Drawing.Point(44, 342);
            this.lblCNewPassword4.Name = "lblCNewPassword4";
            this.lblCNewPassword4.Size = new System.Drawing.Size(288, 30);
            this.lblCNewPassword4.TabIndex = 4;
            this.lblCNewPassword4.Text = " CONFIRM NEW PASSWORD:";
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNewPassword2.Location = new System.Drawing.Point(352, 274);
            this.txtNewPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(311, 46);
            this.txtNewPassword2.TabIndex = 3;
            // 
            // lblNewPassword3
            // 
            this.lblNewPassword3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNewPassword3.Location = new System.Drawing.Point(143, 278);
            this.lblNewPassword3.Name = "lblNewPassword3";
            this.lblNewPassword3.Size = new System.Drawing.Size(189, 34);
            this.lblNewPassword3.TabIndex = 2;
            this.lblNewPassword3.Text = "NEW PASSWORD:";
            // 
            // txtOldPassword1
            // 
            this.txtOldPassword1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtOldPassword1.Location = new System.Drawing.Point(352, 213);
            this.txtOldPassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOldPassword1.Name = "txtOldPassword1";
            this.txtOldPassword1.Size = new System.Drawing.Size(311, 46);
            this.txtOldPassword1.TabIndex = 1;
            // 
            // lblOldPassword2
            // 
            this.lblOldPassword2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblOldPassword2.Location = new System.Drawing.Point(143, 215);
            this.lblOldPassword2.Name = "lblOldPassword2";
            this.lblOldPassword2.Size = new System.Drawing.Size(179, 21);
            this.lblOldPassword2.TabIndex = 0;
            this.lblOldPassword2.Text = "OLD PASSWORD:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 604);
            this.Controls.Add(this.tlpChangePassword1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpChangePassword1.ResumeLayout(false);
            this.grpChangePassword1.ResumeLayout(false);
            this.grpChangePassword1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnBack1;
        private System.Windows.Forms.Button changepwdBTN;
        private System.Windows.Forms.ComboBox cmbUser1;
        private System.Windows.Forms.GroupBox grpChangePassword1;
        private System.Windows.Forms.Label lblCNewPassword4;
        private System.Windows.Forms.Label lblNewPassword3;
        private System.Windows.Forms.Label lblOldPassword2;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.TableLayoutPanel tlpChangePassword1;
        private System.Windows.Forms.TextBox txtCNewPassword3;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.TextBox txtOldPassword1;

        #endregion
    }
}