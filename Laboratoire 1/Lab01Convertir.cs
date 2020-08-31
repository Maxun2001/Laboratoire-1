//Maxime Simard
//2020-08-31
//Convertir Laboratoire 01
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
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //Entrée
            string Valeur = txtValeurAConvertir.Text;
            //Traitement
            if(Valeur == "")
            {
                MessageBox.Show("Veuillez mettre une valeur");
                return;
            }
            MethodeDecimal(Valeur);
            //Sortie
            txtConDecimal.Text = Valeur;
        }

        private void btnHexadécimal_Click(object sender, EventArgs e)
        {
            //Entrée
            string Valeur = txtValeurAConvertir.Text;
            //Traitement           
            if(Valeur[0] != 0 && Valeur[1] != 'x' || Valeur == "")
            {
                MessageBox.Show("Veuillez mettre un 0x pour convertir un Hexadecimal ou veuillez mettre une valeur");
                return;
            }
            Valeur.Remove(0,2);
            MethodeHexaDecimal(Valeur);
            //Sortie
            txtConDecimal.Text = Valeur;
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            //Entrée
            string Valeur = txtValeurAConvertir.Text;
            //traitement
            if (Valeur[0] != 'b' || Valeur == "")
            {
                MessageBox.Show("Veuillez mettre un b pour convertir un Binaire ou veuillez mettre une valeur");
                return;
            }
            Valeur.Remove(0);
            MethodeBinaire(Valeur);
            //Sortie
            txtConDecimal.Text = Valeur;
        }

        private string MethodeDecimal (string Valeur)
        {
            int Resultat = Convert.ToInt32(Valeur);
            string Decimal = Convert.ToString(Resultat,10);
            return Decimal;
        }
        private string MethodeHexaDecimal(string Valeur)
        {
            int Resultat = Convert.ToInt32(Valeur);
            string Hexadecimal = Convert.ToString(Resultat, 16);
            return Hexadecimal;
        }
        private string MethodeBinaire(string Valeur)
        {
            int Resultat = Convert.ToInt32(Valeur);
            string Binaire = Convert.ToString(Resultat, 2);
            return Binaire;
        }


    }
}
