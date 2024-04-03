using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dal;

namespace MediaTek86
{
    partial class Form1
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

        /// <summary>
        /// Créer la vue pour le formulaire de connexion
        /// </summary>
        private void InitializeComponent()
        {
            this.labelconnect = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelpwd = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelconnect
            // 
            this.labelconnect.AutoSize = true;
            this.labelconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.labelconnect.Location = new System.Drawing.Point(138, 48);
            this.labelconnect.Name = "labelconnect";
            this.labelconnect.Size = new System.Drawing.Size(656, 26);
            this.labelconnect.TabIndex = 0;
            this.labelconnect.Text = "Veuillez vous connecter en utilisant vos identifiants de responsable";
            this.labelconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(357, 190);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(129, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labellogin.Location = new System.Drawing.Point(384, 150);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(86, 20);
            this.labellogin.TabIndex = 2;
            this.labellogin.Text = "Identifiant:";
            // 
            // labelpwd
            // 
            this.labelpwd.AutoSize = true;
            this.labelpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelpwd.Location = new System.Drawing.Point(362, 257);
            this.labelpwd.Name = "labelpwd";
            this.labelpwd.Size = new System.Drawing.Size(115, 20);
            this.labelpwd.TabIndex = 4;
            this.labelpwd.Text = "Mot de passe:";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(357, 294);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.PasswordChar = '*';
            this.textBoxPwd.Size = new System.Drawing.Size(129, 20);
            this.textBoxPwd.TabIndex = 3;
            this.textBoxPwd.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(373, 339);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(104, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Se connecter";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(261, 403);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(365, 25);
            this.labelerror.TabIndex = 6;
            this.labelerror.Text = "Identifiant ou mot de passe incorrect!";
            this.labelerror.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(951, 547);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelpwd);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelconnect);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelconnect;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelpwd;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelerror;
    }
}

