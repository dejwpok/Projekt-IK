﻿namespace Projekt_IK.Formularze
{
    partial class Panel_logowania
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
            this.labelLoginTextBox = new System.Windows.Forms.Label();
            this.labelPasswordTextBox = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonGuest = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelErrorLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoginTextBox
            // 
            this.labelLoginTextBox.AutoSize = true;
            this.labelLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginTextBox.Location = new System.Drawing.Point(128, 240);
            this.labelLoginTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginTextBox.Name = "labelLoginTextBox";
            this.labelLoginTextBox.Size = new System.Drawing.Size(199, 39);
            this.labelLoginTextBox.TabIndex = 0;
            this.labelLoginTextBox.Text = "Użytkownik:";
            // 
            // labelPasswordTextBox
            // 
            this.labelPasswordTextBox.AutoSize = true;
            this.labelPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordTextBox.Location = new System.Drawing.Point(171, 359);
            this.labelPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswordTextBox.Name = "labelPasswordTextBox";
            this.labelPasswordTextBox.Size = new System.Drawing.Size(124, 42);
            this.labelPasswordTextBox.TabIndex = 1;
            this.labelPasswordTextBox.Text = "Hasło:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(16, 282);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(439, 46);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(16, 404);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(439, 46);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(305, 478);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(151, 48);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(16, 478);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(151, 48);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonGuest
            // 
            this.buttonGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGuest.Location = new System.Drawing.Point(16, 623);
            this.buttonGuest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(440, 53);
            this.buttonGuest.TabIndex = 6;
            this.buttonGuest.Text = "Zaloguj jako Gość";
            this.buttonGuest.UseVisualStyleBackColor = true;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Projekt_IK.Properties.Resources.person_icon180x180;
            this.pictureBox.Location = new System.Drawing.Point(116, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 222);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // labelErrorLogin
            // 
            this.labelErrorLogin.AutoSize = true;
            this.labelErrorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLogin.Location = new System.Drawing.Point(36, 560);
            this.labelErrorLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorLogin.Name = "labelErrorLogin";
            this.labelErrorLogin.Size = new System.Drawing.Size(378, 31);
            this.labelErrorLogin.TabIndex = 8;
            this.labelErrorLogin.Text = "Niepoprawne dane logowania!";
            this.labelErrorLogin.Visible = false;
            // 
            // Panel_logowania
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(472, 690);
            this.Controls.Add(this.labelErrorLogin);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonGuest);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPasswordTextBox);
            this.Controls.Add(this.labelLoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Panel_logowania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Panel_logowania_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginTextBox;
        private System.Windows.Forms.Label labelPasswordTextBox;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGuest;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelErrorLogin;
    }
}