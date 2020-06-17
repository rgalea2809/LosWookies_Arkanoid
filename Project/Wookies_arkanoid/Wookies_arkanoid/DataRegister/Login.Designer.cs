using System.ComponentModel;

namespace Wookies_arkanoid.Vista
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tlpLogin1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpLogin1 = new System.Windows.Forms.GroupBox();
            this.cmbUserLogin1 = new System.Windows.Forms.ComboBox();
            this.bttnSignUp3 = new System.Windows.Forms.Button();
            this.bttnChangePassword2 = new System.Windows.Forms.Button();
            this.bttnStart1 = new System.Windows.Forms.Button();
            this.txtPasswordLogin1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpLogin1.SuspendLayout();
            this.grpLogin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLogin1
            // 
            this.tlpLogin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpLogin1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("tlpLogin1.BackgroundImage")));
            this.tlpLogin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpLogin1.ColumnCount = 1;
            this.tlpLogin1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogin1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpLogin1.Controls.Add(this.grpLogin1, 0, 0);
            this.tlpLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogin1.Location = new System.Drawing.Point(0, 0);
            this.tlpLogin1.Margin = new System.Windows.Forms.Padding(2);
            this.tlpLogin1.Name = "tlpLogin1";
            this.tlpLogin1.RowCount = 1;
            this.tlpLogin1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogin1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.tlpLogin1.Size = new System.Drawing.Size(716, 406);
            this.tlpLogin1.TabIndex = 0;
            // 
            // grpLogin1
            // 
            this.grpLogin1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpLogin1.AutoSize = true;
            this.grpLogin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpLogin1.BackColor = System.Drawing.Color.Transparent;
            this.grpLogin1.Controls.Add(this.cmbUserLogin1);
            this.grpLogin1.Controls.Add(this.bttnSignUp3);
            this.grpLogin1.Controls.Add(this.bttnChangePassword2);
            this.grpLogin1.Controls.Add(this.bttnStart1);
            this.grpLogin1.Controls.Add(this.txtPasswordLogin1);
            this.grpLogin1.Controls.Add(this.label2);
            this.grpLogin1.Controls.Add(this.label1);
            this.grpLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpLogin1.ForeColor = System.Drawing.Color.White;
            this.grpLogin1.Location = new System.Drawing.Point(98, 12);
            this.grpLogin1.Margin = new System.Windows.Forms.Padding(2);
            this.grpLogin1.Name = "grpLogin1";
            this.grpLogin1.Padding = new System.Windows.Forms.Padding(2);
            this.grpLogin1.Size = new System.Drawing.Size(520, 382);
            this.grpLogin1.TabIndex = 0;
            this.grpLogin1.TabStop = false;
            this.grpLogin1.Text = "Log in";
            // 
            // cmbUserLogin1
            // 
            this.cmbUserLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbUserLogin1.FormattingEnabled = true;
            this.cmbUserLogin1.Location = new System.Drawing.Point(266, 90);
            this.cmbUserLogin1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserLogin1.Name = "cmbUserLogin1";
            this.cmbUserLogin1.Size = new System.Drawing.Size(234, 38);
            this.cmbUserLogin1.TabIndex = 7;
            // 
            // bttnSignUp3
            // 
            this.bttnSignUp3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bttnSignUp3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnSignUp3.Location = new System.Drawing.Point(84, 255);
            this.bttnSignUp3.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSignUp3.Name = "bttnSignUp3";
            this.bttnSignUp3.Size = new System.Drawing.Size(100, 28);
            this.bttnSignUp3.TabIndex = 6;
            this.bttnSignUp3.Text = "SIGN UP";
            this.bttnSignUp3.UseVisualStyleBackColor = false;
            this.bttnSignUp3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnChangePassword2
            // 
            this.bttnChangePassword2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bttnChangePassword2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnChangePassword2.Location = new System.Drawing.Point(310, 255);
            this.bttnChangePassword2.Margin = new System.Windows.Forms.Padding(2);
            this.bttnChangePassword2.Name = "bttnChangePassword2";
            this.bttnChangePassword2.Size = new System.Drawing.Size(206, 32);
            this.bttnChangePassword2.TabIndex = 5;
            this.bttnChangePassword2.Text = "CHANGE PASSWORD";
            this.bttnChangePassword2.UseVisualStyleBackColor = false;
            this.bttnChangePassword2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnStart1
            // 
            this.bttnStart1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.bttnStart1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnStart1.Location = new System.Drawing.Point(236, 196);
            this.bttnStart1.Margin = new System.Windows.Forms.Padding(2);
            this.bttnStart1.Name = "bttnStart1";
            this.bttnStart1.Size = new System.Drawing.Size(86, 28);
            this.bttnStart1.TabIndex = 4;
            this.bttnStart1.Text = "START";
            this.bttnStart1.UseVisualStyleBackColor = false;
            this.bttnStart1.Click += new System.EventHandler(this.startButton_Click);
            // 
            // txtPasswordLogin1
            // 
            this.txtPasswordLogin1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPasswordLogin1.Location = new System.Drawing.Point(266, 145);
            this.txtPasswordLogin1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordLogin1.Name = "txtPasswordLogin1";
            this.txtPasswordLogin1.Size = new System.Drawing.Size(234, 38);
            this.txtPasswordLogin1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(62, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NICKNAME:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 406);
            this.Controls.Add(this.tlpLogin1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpLogin1.ResumeLayout(false);
            this.tlpLogin1.PerformLayout();
            this.grpLogin1.ResumeLayout(false);
            this.grpLogin1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnChangePassword2;
        private System.Windows.Forms.Button bttnSignUp3;
        private System.Windows.Forms.Button bttnStart1;
        private System.Windows.Forms.ComboBox cmbUserLogin1;
        private System.Windows.Forms.GroupBox grpLogin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlpLogin1;
        private System.Windows.Forms.TextBox txtPasswordLogin1;

        #endregion
    }
}