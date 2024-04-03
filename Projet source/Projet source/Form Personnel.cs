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
    public partial class Form3 : Form
    {
        public Form3(bool edit = false, int id = -1, string nom = "", string prenom = "", string tel = "", string mail = "", string service = "")
        {
            InitializeComponent();
            LoadData(edit, id, nom, prenom, tel, mail, service);
        }

        /// <summary>
        /// Se déclence quand le bouton valider BtnValidEdit est clické
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnValidEdit_Click(object sender, EventArgs e)
        {
            sqlreq MyReq = new sqlreq();
            List<service> Services = new List<service>(MyReq.GetServices());
            //Permet de retrouver l'id du service selectionné dans la comboBoxService
            int idservice = 0;
            foreach (service element in Services)
            {
                if(element.getNom() == comboBoxService.SelectedItem.ToString())
                {
                    idservice = element.getId();
                }
            }
            if (label2.Text == "Ajout de personnel") //Si mode Ajout
            {
                if (MyReq.AjoutPersonnel(idservice, textBoxNom.Text, textBoxPrenom.Text, textBoxTel.Text, textBoxMail.Text) > 0)
                {
                    this.Close();
                }
            }
            else 
            {
                if (MyReq.EditPersonnel(int.Parse(labelid.Text), idservice, textBoxNom.Text, textBoxPrenom.Text, textBoxTel.Text, textBoxMail.Text) > 0)
                {
                    this.Close();
                }
            }

        }
    }
}
