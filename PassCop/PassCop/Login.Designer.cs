namespace PassCop
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PassCopLogopictureBox = new System.Windows.Forms.PictureBox();
            this.erroLabel = new System.Windows.Forms.Label();
            this.registarLabel = new System.Windows.Forms.LinkLabel();
            this.novapasswordLink = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.MaskedTextBox();
            this.utilizadorTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.utilizadorLabel = new System.Windows.Forms.Label();
            this.PassCopTextpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassCopLogopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassCopTextpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PassCopLogopictureBox
            // 
            this.PassCopLogopictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PassCopLogopictureBox.Image")));
            this.PassCopLogopictureBox.Location = new System.Drawing.Point(89, -2);
            this.PassCopLogopictureBox.Name = "PassCopLogopictureBox";
            this.PassCopLogopictureBox.Size = new System.Drawing.Size(151, 119);
            this.PassCopLogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassCopLogopictureBox.TabIndex = 22;
            this.PassCopLogopictureBox.TabStop = false;
            // 
            // erroLabel
            // 
            this.erroLabel.AutoSize = true;
            this.erroLabel.ForeColor = System.Drawing.Color.Red;
            this.erroLabel.Location = new System.Drawing.Point(18, 238);
            this.erroLabel.Name = "erroLabel";
            this.erroLabel.Size = new System.Drawing.Size(305, 13);
            this.erroLabel.TabIndex = 21;
            this.erroLabel.Text = "Utlizador ou palavra-passe errados. Por favor tente novamente.";
            // 
            // registarLabel
            // 
            this.registarLabel.AutoSize = true;
            this.registarLabel.Location = new System.Drawing.Point(75, 251);
            this.registarLabel.Name = "registarLabel";
            this.registarLabel.Size = new System.Drawing.Size(63, 13);
            this.registarLabel.TabIndex = 20;
            this.registarLabel.TabStop = true;
            this.registarLabel.Text = "Registar-se.";
            // 
            // novapasswordLink
            // 
            this.novapasswordLink.AutoSize = true;
            this.novapasswordLink.Location = new System.Drawing.Point(154, 252);
            this.novapasswordLink.Name = "novapasswordLink";
            this.novapasswordLink.Size = new System.Drawing.Size(108, 13);
            this.novapasswordLink.TabIndex = 19;
            this.novapasswordLink.TabStop = true;
            this.novapasswordLink.Text = "Nova palavra-passe?";
            this.novapasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.novapasswordLink_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(268, 166);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(66, 69);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Iniciar sessão";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(78, 210);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(184, 25);
            this.passwordTextbox.TabIndex = 17;
            // 
            // utilizadorTextbox
            // 
            this.utilizadorTextbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilizadorTextbox.HideSelection = false;
            this.utilizadorTextbox.Location = new System.Drawing.Point(78, 166);
            this.utilizadorTextbox.Name = "utilizadorTextbox";
            this.utilizadorTextbox.Size = new System.Drawing.Size(184, 25);
            this.utilizadorTextbox.TabIndex = 16;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(131, 194);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(77, 13);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Palavra-passe:";
            // 
            // utilizadorLabel
            // 
            this.utilizadorLabel.AutoSize = true;
            this.utilizadorLabel.Location = new System.Drawing.Point(141, 147);
            this.utilizadorLabel.Name = "utilizadorLabel";
            this.utilizadorLabel.Size = new System.Drawing.Size(53, 13);
            this.utilizadorLabel.TabIndex = 14;
            this.utilizadorLabel.Text = "Utilizador:";
            // 
            // PassCopTextpictureBox
            // 
            this.PassCopTextpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PassCopTextpictureBox.Image")));
            this.PassCopTextpictureBox.Location = new System.Drawing.Point(118, 110);
            this.PassCopTextpictureBox.Name = "PassCopTextpictureBox";
            this.PassCopTextpictureBox.Size = new System.Drawing.Size(100, 50);
            this.PassCopTextpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassCopTextpictureBox.TabIndex = 24;
            this.PassCopTextpictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(339, 273);
            this.Controls.Add(this.erroLabel);
            this.Controls.Add(this.registarLabel);
            this.Controls.Add(this.novapasswordLink);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.utilizadorLabel);
            this.Controls.Add(this.PassCopLogopictureBox);
            this.Controls.Add(this.utilizadorTextbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassCopTextpictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassCop - Início Sessão";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassCopLogopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassCopTextpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PassCopLogopictureBox;
        private System.Windows.Forms.Label erroLabel;
        private System.Windows.Forms.LinkLabel registarLabel;
        private System.Windows.Forms.LinkLabel novapasswordLink;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.MaskedTextBox passwordTextbox;
        private System.Windows.Forms.TextBox utilizadorTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label utilizadorLabel;
        private System.Windows.Forms.PictureBox PassCopTextpictureBox;
    }
}

