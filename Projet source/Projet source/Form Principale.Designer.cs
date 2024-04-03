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
    partial class Form2
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
        /// Créer la vue pour la page principale
        /// </summary>
        private void InitializeComponent()
        {
            this.labelpersonnel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAjoutPers = new System.Windows.Forms.Button();
            this.BtnEditPers = new System.Windows.Forms.Button();
            this.BtnSuppPers = new System.Windows.Forms.Button();
            this.BtnSuppAbs = new System.Windows.Forms.Button();
            this.BtnEditAbs = new System.Windows.Forms.Button();
            this.BtnAjoutAbs = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpersonnel
            // 
            this.labelpersonnel.AutoSize = true;
            this.labelpersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labelpersonnel.Location = new System.Drawing.Point(12, 9);
            this.labelpersonnel.Name = "labelpersonnel";
            this.labelpersonnel.Size = new System.Drawing.Size(220, 29);
            this.labelpersonnel.TabIndex = 0;
            this.labelpersonnel.Text = "Liste du personnel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom,
            this.prenom,
            this.tel,
            this.mail,
            this.service});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 427);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nom
            // 
            this.nom.Frozen = true;
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prenom
            // 
            this.prenom.Frozen = true;
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prenom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tel
            // 
            this.tel.Frozen = true;
            this.tel.HeaderText = "Tel";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mail
            // 
            this.mail.Frozen = true;
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // service
            // 
            this.service.Frozen = true;
            this.service.HeaderText = "Service";
            this.service.Name = "service";
            this.service.ReadOnly = true;
            this.service.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.service.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(1120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Absences";
            // 
            // BtnAjoutPers
            // 
            this.BtnAjoutPers.Location = new System.Drawing.Point(661, 41);
            this.BtnAjoutPers.Name = "BtnAjoutPers";
            this.BtnAjoutPers.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutPers.TabIndex = 5;
            this.BtnAjoutPers.Text = "Ajouter";
            this.BtnAjoutPers.UseVisualStyleBackColor = true;
            this.BtnAjoutPers.Click += new System.EventHandler(this.BtnAjoutPers_Click);
            // 
            // BtnEditPers
            // 
            this.BtnEditPers.Location = new System.Drawing.Point(661, 70);
            this.BtnEditPers.Name = "BtnEditPers";
            this.BtnEditPers.Size = new System.Drawing.Size(75, 23);
            this.BtnEditPers.TabIndex = 6;
            this.BtnEditPers.Text = "Éditer";
            this.BtnEditPers.UseVisualStyleBackColor = true;
            this.BtnEditPers.Click += new System.EventHandler(this.BtnEditPers_Click);
            // 
            // BtnSuppPers
            // 
            this.BtnSuppPers.Location = new System.Drawing.Point(661, 99);
            this.BtnSuppPers.Name = "BtnSuppPers";
            this.BtnSuppPers.Size = new System.Drawing.Size(75, 23);
            this.BtnSuppPers.TabIndex = 7;
            this.BtnSuppPers.Text = "Supprimer";
            this.BtnSuppPers.UseVisualStyleBackColor = true;
            this.BtnSuppPers.Click += new System.EventHandler(this.BtnSuppPers_Click);
            // 
            // BtnSuppAbs
            // 
            this.BtnSuppAbs.Location = new System.Drawing.Point(1251, 99);
            this.BtnSuppAbs.Name = "BtnSuppAbs";
            this.BtnSuppAbs.Size = new System.Drawing.Size(75, 23);
            this.BtnSuppAbs.TabIndex = 10;
            this.BtnSuppAbs.Text = "Supprimer";
            this.BtnSuppAbs.UseVisualStyleBackColor = true;
            this.BtnSuppAbs.Click += new System.EventHandler(this.BtnSuppAbs_Click);
            // 
            // BtnEditAbs
            // 
            this.BtnEditAbs.Location = new System.Drawing.Point(1251, 70);
            this.BtnEditAbs.Name = "BtnEditAbs";
            this.BtnEditAbs.Size = new System.Drawing.Size(75, 23);
            this.BtnEditAbs.TabIndex = 9;
            this.BtnEditAbs.Text = "Éditer";
            this.BtnEditAbs.UseVisualStyleBackColor = true;
            this.BtnEditAbs.Click += new System.EventHandler(this.BtnEditAbs_Click);
            // 
            // BtnAjoutAbs
            // 
            this.BtnAjoutAbs.Location = new System.Drawing.Point(1251, 41);
            this.BtnAjoutAbs.Name = "BtnAjoutAbs";
            this.BtnAjoutAbs.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutAbs.TabIndex = 8;
            this.BtnAjoutAbs.Text = "Ajouter";
            this.BtnAjoutAbs.UseVisualStyleBackColor = true;
            this.BtnAjoutAbs.Click += new System.EventHandler(this.BtnAjoutAbs_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.Location = new System.Drawing.Point(902, 41);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(343, 427);
            this.dataGridView2.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Date début";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date Fin";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Motif";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1363, 531);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnSuppAbs);
            this.Controls.Add(this.BtnEditAbs);
            this.Controls.Add(this.BtnAjoutAbs);
            this.Controls.Add(this.BtnSuppPers);
            this.Controls.Add(this.BtnEditPers);
            this.Controls.Add(this.BtnAjoutPers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelpersonnel);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Remplie les deux éléments de type datagridview avec les données de la bdd
        /// </summary>
        public Dictionary<int, List<int>> DictABS = new Dictionary<int, List<int>>();
        public void RemplirDataGrid()
        {

            sqlreq SqlSelect = new sqlreq();
            List<service> Services = new List<service>(SqlSelect.GetServices());
            List<motif> Motifs = new List<motif>(SqlSelect.GetMotifs());
            List<Personnel> data = new List<Personnel>(SqlSelect.GetPersonnel());
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView2.SelectionChanged += DataGridView2_SelectionChanged;
            foreach (Personnel element in data)
            {
                List<string> infos = element.Getinfos();
                int compte = dataGridView1.Rows.Add();
                dataGridView1.Rows[compte].Cells[0].Value = infos[0];
                dataGridView1.Rows[compte].Cells[1].Value = infos[2];
                dataGridView1.Rows[compte].Cells[2].Value = infos[3];
                dataGridView1.Rows[compte].Cells[3].Value = infos[4];
                dataGridView1.Rows[compte].Cells[4].Value = infos[5];
                dataGridView1.Rows[compte].Cells[5].Value = Services[int.Parse(infos[1]) - 1].getNom();
                dataGridView1.Rows[compte].Selected = false;

                DictABS.Add(compte, new List<int>());
                foreach (absence abs in element.GetAbsences())
                {
                    List<int> AbsIdList = new List<int>();
                    List<string> absInfos = abs.GetAbsInfo();
                    string labelmotif = "";
                    foreach (motif motif in Motifs)
                    {
                        if (motif.getId() == int.Parse(absInfos[0]))
                        {
                            labelmotif = motif.getLibelle();
                        }
                    }
                    int compte2 = dataGridView2.Rows.Add();
                    dataGridView2.Rows[compte2].Cells[0].Value = absInfos[1];
                    dataGridView2.Rows[compte2].Cells[1].Value = absInfos[2];
                    dataGridView2.Rows[compte2].Cells[2].Value = labelmotif;
                    dataGridView2.Rows[compte2].Visible = false;
                    dataGridView2.Rows[compte2].Selected = false;

                    DictABS[compte].Add(compte2);
                }
            }
        }


        private System.Windows.Forms.Label labelpersonnel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAjoutPers;
        private System.Windows.Forms.Button BtnEditPers;
        private System.Windows.Forms.Button BtnSuppPers;
        private System.Windows.Forms.Button BtnSuppAbs;
        private System.Windows.Forms.Button BtnEditAbs;
        private System.Windows.Forms.Button BtnAjoutAbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}