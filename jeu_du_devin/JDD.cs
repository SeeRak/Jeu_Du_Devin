using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeu_du_devin
{
    public partial class FDevin : Form
    {
        // Déclaration des attributs
        private int NbMystere;
        private int NbEssais;
        private Int16 Proposition;
        private bool Trouve;
        private Int16 NbTentatives;

        public FDevin()
        {
            InitializeComponent();
        }

        private void FDevin_Load(object sender, EventArgs e)
        {
            Proposition = 0;
            NbEssais = 0;
            NbTentatives = 0;
            Trouve = false;

            Rad10coups.Enabled = false;
            Rad15coups.Enabled = false;
            Rad20coups.Enabled = false;
            Rad25coups.Enabled = false;
            Rad30coups.Enabled = false;
        }

        private void BoutonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BoutonNewGame_Click(object sender, EventArgs e)
        {
            Proposition = 0;
            NbEssais = 0;
            NbTentatives = 0;
            Trouve = false;
            Rad10coups.Enabled = true;
            Rad15coups.Enabled = true;
            Rad20coups.Enabled = true;
            Rad25coups.Enabled = true;
            Rad30coups.Enabled = true;

            MessageJeu.Clear();

            Random aleatoire = new Random();
            NbMystere = aleatoire.Next(1, 10000); // Génère un entier compris entre 1 et 10000


        }

        private void Rad10coups_CheckedChanged(object sender, EventArgs e)
        {
            // Ici l'idée est de savoir quel RadioButton a été cheké, pour cela on va créer un radioButton témoin
            // qui va récuperer les propriétés du radiobutton chéké, pour connaitre le nombre d'essais choisi par
            // l'utilisateur il suffit de lire la propriété Tag du raddiobutton appelant.
            string Etiquette;
            RadioButton RadioCheck = (RadioButton)sender;
            Etiquette = (string)RadioCheck.Tag;
            NbEssais = Convert.ToInt16(Etiquette);
            MessageJeu.AppendText("La partie va commencer, vous disposez de " + NbEssais + " tentatives ! \n");

            Rad10coups.Enabled = false;
            Rad15coups.Enabled = false;
            Rad20coups.Enabled = false;
            Rad25coups.Enabled = false;
            Rad30coups.Enabled = false;
            BoutonNewGame.Enabled = false;
            MessageJeu.AppendText("Vous devez trouver le nombre choisi par ce programme, ce nombre est compris entre 0 et 10000. \n");
            MessageJeu.AppendText("Entrez votre proposition dans la zone prévue à cette effet. ");
            EditProposition.Enabled = true;
            EditProposition.Select();
        }

        private void EditProposition_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {


                if (e.KeyChar == (char)Keys.Return)
                {
                    Proposition = Convert.ToInt16(EditProposition.Text);
                    NbTentatives++;

                    if (Proposition == NbMystere)
                    {
                        Trouve = true;
                    }
                    else
                    {
                        if (Proposition < NbMystere)
                        {
                            MessageJeu.AppendText("Trop petit ! \n");
                        }
                        else
                        {
                            MessageJeu.AppendText("Trop grand ! \n");
                        }
                    }
                    if (Trouve == true)
                    {
                        MessageJeu.AppendText("Vous avez découvert le nombre mystere en " + NbTentatives + " essais");
                        BoutonNewGame.Enabled = true;
                        EditProposition.Enabled = false;

                    }

                    if ((Trouve != true) && (NbTentatives >= NbEssais))
                    {
                        MessageJeu.AppendText("Désolé vous avez atteint le maximum de tentatives");
                        MessageJeu.AppendText("Le nombre mystère était " + NbMystere);
                        BoutonNewGame.Enabled = true;
                        EditProposition.Enabled = false;
                    }

                    string old1 = EditProposition.Text;

                    string news1 = this.EditProposition.Text.Remove(this.EditProposition.Text.Length - EditProposition.Text.Length);
                    EditProposition.Text = news1;

                }
            }catch
            {

            }
        }       
    }
}
