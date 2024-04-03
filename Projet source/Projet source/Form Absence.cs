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
    public partial class Form4 : Form
    {
        public Form4(bool edit = false, int id = -1, string debut = " ", string fin = " ", string motif = " ", string nom = "")
        {
            InitializeComponent();
            LoadData(edit, id, debut, fin, motif, nom);
        }

        /// <summary>
        /// Se déclenche quand le bouton valider BtnValid est clické
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValid_Click(object sender, EventArgs e)
        {
            sqlreq MyReq = new sqlreq();
            List<motif> Motifs = new List<motif>(MyReq.GetMotifs());
            //Permet de retrouver l'id du motif selectionné dans la comboBoxMotif
            int idmotif = 0;
            foreach (motif element in Motifs)
            {
                if (element.getLibelle() == comboBoxMotif.SelectedItem.ToString())
                {
                    idmotif = element.getId();
                }
            }
            if (labeltitre.Text.ToString().Split(' ')[0] == "Ajout") //Si mode Ajout
            {
                if (MyReq.AjoutAbsence(int.Parse(labelidpers.Text), DateTime.Parse(DtpDebut.Value.ToString().Split(' ')[0]) , DateTime.Parse(DtpFin.Value.ToString().Split(' ')[0]), idmotif) > 0)
                { 
                    this.Close();
                }
            }
            else
            {
                if (MyReq.EditAbsence(int.Parse(labelidpers.Text), DateTime.Parse(DtpDebut.Value.ToString().Split(' ')[0]), DateTime.Parse(DtpFin.Value.ToString().Split(' ')[0]), idmotif, DateTime.Parse(labelOldDebut.Text)) > 0)
                {
                    this.Close();
                }
            }
        }
    }
}
