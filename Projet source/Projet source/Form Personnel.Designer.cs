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
using modele;

namespace MediaTek86
{
    partial class Form3
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
        /// <summary>
        /// Créer la vue pour le formulaire d'édition/ajout du personnel
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelnom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.BtnValidEdit = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Enabled = false;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(-5, -14);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(807, 63);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(303, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLACEHOLDER";
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelnom.Location = new System.Drawing.Point(154, 107);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(49, 20);
            this.labelnom.TabIndex = 4;
            this.labelnom.Text = "Nom:";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(158, 130);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(160, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(154, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prénom:";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(158, 204);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(160, 20);
            this.textBoxPrenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(428, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tel:";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(432, 181);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(163, 20);
            this.textBoxTel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(154, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Service:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(428, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mail:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(432, 258);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(163, 20);
            this.textBoxMail.TabIndex = 11;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(158, 279);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(160, 21);
            this.comboBoxService.TabIndex = 13;
            // 
            // BtnValidEdit
            // 
            this.BtnValidEdit.Location = new System.Drawing.Point(706, 426);
            this.BtnValidEdit.Name = "BtnValidEdit";
            this.BtnValidEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnValidEdit.TabIndex = 14;
            this.BtnValidEdit.Text = "Valider";
            this.BtnValidEdit.UseVisualStyleBackColor = true;
            this.BtnValidEdit.Click += new System.EventHandler(this.BtnValidEdit_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Enabled = false;
            this.labelid.Location = new System.Drawing.Point(13, 446);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(97, 13);
            this.labelid.TabIndex = 15;
            this.labelid.Text = "IDPLACEHOLDER";
            this.labelid.Visible = false;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(796, 485);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.BtnValidEdit);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form3";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Remplie les éléments avec les donénes précedement selectionnées (valeurs par défaut si mode ajout)
        /// </summary>
        private void LoadData(bool edit = false, int id = -1, string nom = "", string prenom = "", string tel = "", string mail = "", string service = "")
        {
            sqlreq MyReq = new sqlreq();
            List<service> Services = new List<service>(MyReq.GetServices());

            label2.Text = edit ? "Édition de " + nom + " " + prenom : "Ajout de personnel"; //Définie le text affiché en haut du formulaire
            //Rempli la comboBoxService avec les données de la bdd
            int idservice = 0;
            foreach (service element in Services)
            {
                comboBoxService.Items.Add(element.getNom());
                //(Si édition)Permet de determiner l'id du service du personnel selectionné 
                if (element.getNom() == service)
                {
                    idservice = element.getId();
                }
            }
            if (edit)
            {
                //(Si édition)Permet a la comboBoxService d'avoir pour valeur selectionnée la valeur actuel du service du personnel selectionné 
                comboBoxService.SelectedIndex = idservice - 1;
            }
            else
            {
                //Valeur par défaut
                comboBoxService.SelectedIndex = 0;
            }
            labelid.Text = id.ToString(); //Label caché sert uniquement pour assurer le transfert de l'id
            textBoxNom.Text = nom; //Zone de text Nom:
            textBoxPrenom.Text = prenom; //Zone de text Prénom:
            textBoxTel.Text = tel; //Zone de text Tel:
            textBoxMail.Text = mail; //Zone de text Mail:
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button BtnValidEdit;
        private System.Windows.Forms.Label labelid;
    }
}