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
    partial class Form4
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labeltitre = new System.Windows.Forms.Label();
            this.labelmotif = new System.Windows.Forms.Label();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.DtpDebut = new System.Windows.Forms.DateTimePicker();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.labeldebut = new System.Windows.Forms.Label();
            this.labelfin = new System.Windows.Forms.Label();
            this.BtnValid = new System.Windows.Forms.Button();
            this.labelidpers = new System.Windows.Forms.Label();
            this.labelOldDebut = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labeltitre, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-5, -13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0064F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labeltitre
            // 
            this.labeltitre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitre.AutoSize = true;
            this.labeltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labeltitre.Location = new System.Drawing.Point(304, 18);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(200, 29);
            this.labeltitre.TabIndex = 0;
            this.labeltitre.Text = "PLACEHOLDER";
            // 
            // labelmotif
            // 
            this.labelmotif.AutoSize = true;
            this.labelmotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelmotif.Location = new System.Drawing.Point(290, 136);
            this.labelmotif.Name = "labelmotif";
            this.labelmotif.Size = new System.Drawing.Size(51, 20);
            this.labelmotif.TabIndex = 1;
            this.labelmotif.Text = "Motif:";
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(293, 163);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMotif.TabIndex = 2;
            // 
            // DtpDebut
            // 
            this.DtpDebut.Location = new System.Drawing.Point(77, 278);
            this.DtpDebut.Name = "DtpDebut";
            this.DtpDebut.Size = new System.Drawing.Size(200, 20);
            this.DtpDebut.TabIndex = 3;
            // 
            // DtpFin
            // 
            this.DtpFin.Location = new System.Drawing.Point(476, 278);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(200, 20);
            this.DtpFin.TabIndex = 4;
            // 
            // labeldebut
            // 
            this.labeldebut.AutoSize = true;
            this.labeldebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labeldebut.Location = new System.Drawing.Point(73, 255);
            this.labeldebut.Name = "labeldebut";
            this.labeldebut.Size = new System.Drawing.Size(119, 20);
            this.labeldebut.TabIndex = 7;
            this.labeldebut.Text = "Date de début:";
            // 
            // labelfin
            // 
            this.labelfin.AutoSize = true;
            this.labelfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelfin.Location = new System.Drawing.Point(472, 255);
            this.labelfin.Name = "labelfin";
            this.labelfin.Size = new System.Drawing.Size(96, 20);
            this.labelfin.TabIndex = 8;
            this.labelfin.Text = "Date de fin:";
            // 
            // BtnValid
            // 
            this.BtnValid.Location = new System.Drawing.Point(713, 415);
            this.BtnValid.Name = "BtnValid";
            this.BtnValid.Size = new System.Drawing.Size(75, 23);
            this.BtnValid.TabIndex = 9;
            this.BtnValid.Text = "Valider";
            this.BtnValid.UseVisualStyleBackColor = true;
            this.BtnValid.Click += new System.EventHandler(this.BtnValid_Click);
            // 
            // labelidpers
            // 
            this.labelidpers.AutoSize = true;
            this.labelidpers.Enabled = false;
            this.labelidpers.Location = new System.Drawing.Point(12, 420);
            this.labelidpers.Name = "labelidpers";
            this.labelidpers.Size = new System.Drawing.Size(97, 13);
            this.labelidpers.TabIndex = 16;
            this.labelidpers.Text = "IDPLACEHOLDER";
            this.labelidpers.Visible = false;
            // 
            // labelOldDebut
            // 
            this.labelOldDebut.AutoSize = true;
            this.labelOldDebut.Enabled = false;
            this.labelOldDebut.Location = new System.Drawing.Point(12, 407);
            this.labelOldDebut.Name = "labelOldDebut";
            this.labelOldDebut.Size = new System.Drawing.Size(115, 13);
            this.labelOldDebut.TabIndex = 17;
            this.labelOldDebut.Text = "DATEPLACEHOLDER";
            this.labelOldDebut.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOldDebut);
            this.Controls.Add(this.labelidpers);
            this.Controls.Add(this.BtnValid);
            this.Controls.Add(this.labelfin);
            this.Controls.Add(this.labeldebut);
            this.Controls.Add(this.DtpFin);
            this.Controls.Add(this.DtpDebut);
            this.Controls.Add(this.comboBoxMotif);
            this.Controls.Add(this.labelmotif);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Remplie les éléments avec les donénes précedement selectionnées (valeurs par défaut si mode ajout)
        /// </summary>
        public void LoadData(bool edit = false, int id = -1, string debut = " ", string fin = " ", string motif = " ", string nom = "")
        {
            Console.WriteLine(motif);

            sqlreq MyReq = new sqlreq();
            List<motif> Motifs = new List<motif>(MyReq.GetMotifs());
            labeltitre.Text = edit ? "Édiiton de l'absence de " + nom : "Ajout d'absence "; //Définie le text affiché en haut du formulaire
            //Rempli la comboBoxService avec les données de la bdd
            int idmotif = 0;
            foreach (motif element in Motifs)
            {
                //(Si édition)Permet de determiner l'id du service du personnel selectionné 
                comboBoxMotif.Items.Add(element.getLibelle());
                if (element.getLibelle() == motif)
                {
                    idmotif = element.getId();
                    Console.WriteLine(idmotif);
                }
            }
            if (edit) //Si mode edition 
            {

                comboBoxMotif.SelectedIndex = idmotif - 1; 
                DtpDebut.Value = DateTime.Parse(debut); //DateTimePicker Date début
                DtpFin.Value = DateTime.Parse(fin); //DateTimePicker Date Fin
            }
            else
            {
                comboBoxMotif.SelectedIndex = 0;
            }
            labelOldDebut.Text = debut; //Label caché sert uniquement pour assurer le transfert de l'ancienne date de début afin de pouvoir retrouver la ligne a modifier dans la bdd
            labelidpers.Text = id.ToString(); //Label caché sert uniquement pour assurer le transfert de l'id
        }
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Label labelmotif;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.DateTimePicker DtpDebut;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.Label labeldebut;
        private System.Windows.Forms.Label labelfin;
        private System.Windows.Forms.Button BtnValid;
        private System.Windows.Forms.Label labelidpers;
        private System.Windows.Forms.Label labelOldDebut;
    }
}