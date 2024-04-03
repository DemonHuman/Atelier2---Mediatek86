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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se déclence quand le bouton "Se connecter" est clické
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sqlreq Req = new sqlreq();
            if (Req.checkLogin(textBoxLogin.Text, textBoxPwd.Text))
            {
                //Ferme le formulaire de connexion
                this.Hide();
                //Ouvre la page principale
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                //Message d'erreur: "Identifiants ou mot de passe invalde"
                labelerror.Visible = true;
            }
        }
    }
}
