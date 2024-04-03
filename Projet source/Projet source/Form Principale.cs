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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            RemplirDataGrid();
        }

        /// <summary>
        /// Se déclenche quand le bouton Ajouter BtnAjoutPers a droite du tableau datagridview1 du personnel est clické
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjoutPers_Click(object sender, EventArgs e)
        {
            //Ouvre le formulaire d'ajoute/édition du personnel
            Form3 f3 = new Form3();
            f3.Show();
            f3.FormClosed += Form3_FromClosed;
        }

        /// <summary>
        /// Se déclence quand le bouton Éditer BtnEditPers a droite du tableau datagridview1 du personnel est clické
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditPers_Click(object sender, EventArgs e)
        {
            //Ouvre le formulaire d'ajoute/édition du personnel
            Form3 f3 = new Form3(
                true, //Indique que le formulaire doit etre ouvert en mode édition
                int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].FormattedValue.ToString()), //Correspond a l'id du personnel séléctionné
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].FormattedValue.ToString(), //Correspond au nom du personnel séléctionné
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].FormattedValue.ToString(), //Correspond au prénom du personnel séléctionné
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].FormattedValue.ToString(), //Correspond au tel du personnel séléctionné
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].FormattedValue.ToString(), //Correspond au mail du personnel séléctionné
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].FormattedValue.ToString()); //Correspond au nom du service du personnel séléctionné
            f3.Show();
            f3.FormClosed += Form3_FromClosed;
        }

        /// <summary>
        /// Se déclenche quand le bouton Supprimer BtnSuppPers a droite du tableau datagridview1 du personnel est clické
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuppPers_Click(object sender, EventArgs e)
        {
            //Demande a l'utilisateur de confirmer la suppression
            var confirmResult = MessageBox.Show("Êtes-vous sur de vouloir supprimer : " +
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].FormattedValue.ToString() +
                " " + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].FormattedValue.ToString(), "Veuillez confirmez.", MessageBoxButtons.YesNo);
            //Si oui
            if (confirmResult == DialogResult.Yes)
            {
                sqlreq SqlReq = new sqlreq();
                SqlReq.SuppPersonnel(int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].FormattedValue.ToString()));
                //Actualise les deux éléments de type datagridview sur la page prinicpale
                DictABS.Clear();
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                RemplirDataGrid();
                BtnEditPers.Enabled = false;
                BtnSuppPers.Enabled = false;
                BtnAjoutAbs.Enabled = false;
                BtnEditAbs.Enabled = false;
                BtnSuppAbs.Enabled = false;
                ///
            }
        }

        /// <summary>
        /// Se déclenche quand le formulaire d'ajout/édition du personnel Form3 est fermé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_FromClosed(object sender, FormClosedEventArgs e)
        {
            //Actualise les deux éléments de type datagridview sur la page prinicpale
            DictABS.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            RemplirDataGrid();
            BtnEditPers.Enabled = false;
            BtnSuppPers.Enabled = false;
            BtnAjoutAbs.Enabled = false;
            BtnEditAbs.Enabled = false;
            BtnSuppAbs.Enabled = false;
            ///
        }

        /// <summary>
        /// Se déclenche quand l'utilisateur selectionne une ligne du tableau datagridview1 du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            BtnEditPers.Enabled = true;
            BtnSuppPers.Enabled = true;
            BtnAjoutAbs.Enabled = true;
            if (DictABS.Count > 0)
            {
                //Cache toutes les lignes dans le tableau datagridview2 des absences
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.Visible = false;
                }
                //Affiche toutes les lignes du tableau datagridview2 des absences qui correspondent aux absence du personnel selectionné dans le tableau datagridview1
                foreach (int id in DictABS[dataGridView1.SelectedRows[0].Index])
                {
                    dataGridView2.Rows[id].Visible = true;
                    dataGridView2.Rows[id].Selected = true;
                }
            }
        }

        /// <summary>
        /// Se déclenche quand l'utilisateur selectionne une ligne du tableau datagridview2 des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            BtnEditAbs.Enabled = true;
            BtnSuppAbs.Enabled = true;
        }

        /// <summary>
        /// Se délenche quand le bouton Ajouter BtnAjoutAbs a droite du tableau absence est clické
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjoutAbs_Click(object sender, EventArgs e)
        {
            //Ouvre le formulaire d'ajoute/édiiton d'une absence Form4
            Form4 f4 = new Form4(
                false, //Indique que le formulaire doit être ouvert en mode ajout
                int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].FormattedValue.ToString())); //Correspond a l'id du personnel séléctionné 
            f4.Show();
            f4.FormClosed += Form4_FromClosed;
        }

        /// <summary>
        /// Se délenche quand le bouton Éditer BtnEditAbs a droite du tableau absence est clické
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditAbs_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(
                true, //Indique que le formulaire doit etre ouvert en mode édition
                int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].FormattedValue.ToString()), //Correspond a l'id du personnel selectionné
                dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].FormattedValue.ToString(), //Correspond a la date de début de l'absence selectionnée
                dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[1].FormattedValue.ToString(), //Correspond a la date de fin de l'absence selectionnée
                dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[2].FormattedValue.ToString(), //Correspond au libelle du motif de l'absence
                dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].FormattedValue.ToString() + " " + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].FormattedValue.ToString()); //Correspond a une chaine du nom + prenom du personnel selectionné
            f4.Show();
            f4.FormClosed += Form4_FromClosed;
        }

        /// <summary>
        /// Se délenche quand le bouton Ajouter BtnAjoutAbs a droite du tableau absence est clické
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuppAbs_Click(object sender, EventArgs e)
        {
            //Demande a l'utilisateur de confirmer la suppression
            var confirmResult = MessageBox.Show("Êtes-vous sur de vouloir supprimer l'absence de : " +
                            dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].FormattedValue.ToString() +
                            " " + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].FormattedValue.ToString() +
                            " du " + dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].FormattedValue.ToString(), "Veuillez confirmez.", MessageBoxButtons.YesNo);
            //Si oui
            if (confirmResult == DialogResult.Yes)
            {
                sqlreq SqlReq = new sqlreq();
                SqlReq.SuppAbsence(
                    int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].FormattedValue.ToString()), //Correspond a l'id du personnel selectionné
                    DateTime.Parse(dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].FormattedValue.ToString())); //Correspond a la date de debut de l'absence selectionnée
                //Actualise les deux éléments de type datagridview sur la page prinicpale
                DictABS.Clear();
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                RemplirDataGrid();
                BtnEditPers.Enabled = false;
                BtnSuppPers.Enabled = false;
                BtnAjoutAbs.Enabled = false;
                BtnEditAbs.Enabled = false;
                BtnSuppAbs.Enabled = false;
                //
            }
}

        /// <summary>
        /// Se déclenche quand le formulaire d'ajout/édition d'une absence Form4 est fermé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_FromClosed(object sender, FormClosedEventArgs e)
        {
            //Actualise les deux éléments de type datagridview sur la page prinicpale
            DictABS.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            RemplirDataGrid();
            BtnEditPers.Enabled = false;
            BtnSuppPers.Enabled = false;
            BtnAjoutAbs.Enabled = false;
            BtnEditAbs.Enabled = false;
            BtnSuppAbs.Enabled = false;
            ///
        }

    }
}
