namespace CuisiHome
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnViderChamp = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtBoxUtilisateur = new System.Windows.Forms.TextBox();
            this.txtBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(352, 231);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnViderChamp
            // 
            this.btnViderChamp.Location = new System.Drawing.Point(468, 231);
            this.btnViderChamp.Name = "btnViderChamp";
            this.btnViderChamp.Size = new System.Drawing.Size(150, 33);
            this.btnViderChamp.TabIndex = 1;
            this.btnViderChamp.Text = "Vider les champs";
            this.btnViderChamp.UseVisualStyleBackColor = true;
            this.btnViderChamp.Click += new System.EventHandler(this.btnViderChamp_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(672, 231);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(80, 33);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Location = new System.Drawing.Point(348, 91);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(80, 20);
            this.lblUtilisateur.TabIndex = 3;
            this.lblUtilisateur.Text = "Utilisateur";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(348, 133);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(105, 20);
            this.lblMotDePasse.TabIndex = 4;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // txtBoxUtilisateur
            // 
            this.txtBoxUtilisateur.Location = new System.Drawing.Point(468, 88);
            this.txtBoxUtilisateur.Name = "txtBoxUtilisateur";
            this.txtBoxUtilisateur.Size = new System.Drawing.Size(284, 26);
            this.txtBoxUtilisateur.TabIndex = 5;
            // 
            // txtBoxMotDePasse
            // 
            this.txtBoxMotDePasse.Location = new System.Drawing.Point(468, 133);
            this.txtBoxMotDePasse.Name = "txtBoxMotDePasse";
            this.txtBoxMotDePasse.Size = new System.Drawing.Size(284, 26);
            this.txtBoxMotDePasse.TabIndex = 6;
            this.txtBoxMotDePasse.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 349);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxMotDePasse);
            this.Controls.Add(this.txtBoxUtilisateur);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblUtilisateur);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnViderChamp);
            this.Controls.Add(this.btnLogin);
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnViderChamp;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtBoxUtilisateur;
        private System.Windows.Forms.TextBox txtBoxMotDePasse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

