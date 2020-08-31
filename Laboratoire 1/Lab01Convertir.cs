using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratoire_1
{
    public partial class FrmConvertir : Form
    {
        //Modification de programme
        public FrmConvertir()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //Entrée
            String Valeur = txtValeurAConvertir.Text;

            
            //Traitement
            if(Valeur=="")
            {
                Valeur = "0";
            }


            //Sortie
            txtConDecimal.Text = Valeur;
        }

        private void btnHexadécimal_Click(object sender, EventArgs e)
        {
            //Entrée
            String Valeur = txtValeurAConvertir.Text;


            //Traitement
            if (Valeur == "")
            {
                Valeur = "0";
            }
            

            //Sortie
            txtConDecimal.Text = Valeur;
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            //Entrée
            String Valeur = txtValeurAConvertir.Text;


            //Traitement
            if (Valeur == "")
            {
                Valeur = "0";
            }


            //Sortie
            txtConDecimal.Text = Valeur;
        }
    }
}
