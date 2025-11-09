namespace Library
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBoxPinterest = new System.Windows.Forms.PictureBox();
            this.pictureBoxInstragram = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPinterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstragram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Thistle;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(101, 218);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(254, 29);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(43, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(104, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(101, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 1);
            this.panel2.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Thistle;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(101, 293);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 28);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Password";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Purple;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(43, 356);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(325, 48);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.White;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.Purple;
            this.btnSignup.Location = new System.Drawing.Point(43, 425);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(325, 48);
            this.btnSignup.TabIndex = 10;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(377, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 32);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBoxPinterest
            // 
            this.pictureBoxPinterest.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPinterest.Image")));
            this.pictureBoxPinterest.Location = new System.Drawing.Point(60, 491);
            this.pictureBoxPinterest.Name = "pictureBoxPinterest";
            this.pictureBoxPinterest.Size = new System.Drawing.Size(87, 72);
            this.pictureBoxPinterest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPinterest.TabIndex = 12;
            this.pictureBoxPinterest.TabStop = false;
            this.pictureBoxPinterest.Click += new System.EventHandler(this.pictureBoxPinterest_Click);
            // 
            // pictureBoxInstragram
            // 
            this.pictureBoxInstragram.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInstragram.Image")));
            this.pictureBoxInstragram.Location = new System.Drawing.Point(165, 491);
            this.pictureBoxInstragram.Name = "pictureBoxInstragram";
            this.pictureBoxInstragram.Size = new System.Drawing.Size(87, 72);
            this.pictureBoxInstragram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInstragram.TabIndex = 13;
            this.pictureBoxInstragram.TabStop = false;
            this.pictureBoxInstragram.Click += new System.EventHandler(this.pictureBoxInstragram_Click);
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFacebook.Image")));
            this.pictureBoxFacebook.Location = new System.Drawing.Point(267, 491);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(87, 72);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 14;
            this.pictureBoxFacebook.TabStop = false;
            this.pictureBoxFacebook.Click += new System.EventHandler(this.pictureBoxFacebook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(410, 603);
            this.Controls.Add(this.pictureBoxFacebook);
            this.Controls.Add(this.pictureBoxInstragram);
            this.Controls.Add(this.pictureBoxPinterest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPinterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstragram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxPinterest;
        private System.Windows.Forms.PictureBox pictureBoxInstragram;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
    }
}

