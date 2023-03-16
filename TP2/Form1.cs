namespace TP2
{
    public partial class Form1 : Form
    {

        private String[] tabMots;
        private int nbEssaisRestants;
        private int nbEssaisPrecedents;
        private String motATrouver;
        private int nbParties;

        public Form1()
        {
            InitializeComponent();
        }

        private void initialisation()
        {
            tabMots = new string[] { "ELEPHANT", "ALPHABET", "TORTUE", "VOITURE", "SOLEIL", "CITROUILLE" };
            txtbxPropo.CharacterCasing = CharacterCasing.Upper;
            nbParties = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialisation();
            nouvellePartie();
        }

        private String melanger(String chaine)
        {
            String motMelange = ""; //Prend un mot "chaine", le mélange et le retourne mélangé
            Random rnd = new Random();
            int x = 0;
            while (chaine.Length > 0)
            {
                int y = chaine.Length;
                int nb = rnd.Next(x, y);
                motMelange += chaine[nb];
                chaine = chaine.Remove(nb, 1);
            }
            return motMelange;

        }

        private void nouvellePartie()
        {
            int x = 0;
            int y = tabMots.Length;
            Random random = new Random();
            int nb = random.Next(x, y);
            String motAlea = tabMots[nb]; //On prend un mot aléatoire de la liste

            nbEssaisRestants = 10;
            nbEssaisPrecedents = 0;
            lblEssaisRestants.Text = "" + nbEssaisRestants;
            lblEssaisPrecedents.Text = "" + nbEssaisPrecedents;

            lbxEssais.Items.Clear(); //On clear les essais precedents

            motATrouver = motAlea;//Le mot à trouver est stocké
            String motATrouverMELANGE = melanger(motAlea); //Le mot aléatoire est mélangé et montré à l'utilisateur
            lblMOT.Text = motATrouverMELANGE;

        }

        private void motCorrect()
        {
            //MessageBox.Show("Voulez-vous vrm quitter ?", "QUITTER?", "oui");
            const string message =
            "Vous avez gagné eheh! Voulez-vous rejouer UwU ?";
            const string caption = "GAGNÉ ! :D";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                nbParties++;
                nbEssaisPrecedents++;
                lbxHistorique.BeginUpdate(); //On ajoute le mot dans l'historique !
                lbxHistorique.Items.Add("Partie " + nbParties + " - " + motATrouver + " - Gagnée - " + nbEssaisPrecedents + " coups");
                lbxHistorique.EndUpdate();

                nouvellePartie();

            }
            else if (result == DialogResult.No)
            {
                this.Dispose();
            }
        }

        private void motIncorrect(String mot)
        {
            if (nbEssaisRestants != 1)
            {
                nbEssaisRestants--;
                nbEssaisPrecedents = 10 - nbEssaisRestants;
                lblEssaisRestants.Text = "" + nbEssaisRestants;
                lblEssaisPrecedents.Text = "" + nbEssaisPrecedents;

                // Mettre à jour l'affichage du nombre d'essais restants et précedents
                lbxEssais.BeginUpdate();
                lbxEssais.Items.Add(mot);
                lbxEssais.EndUpdate();


            }
            else
            {
                // Afficher le mot à trouver
                // Demander à l'utilisateur s'il veut rejouer
                string message = "Vous avez perdu. Le mot à trouver était : " + motATrouver + "\nVoulez-vous rejouer ?";
                const string caption = "Perdu";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    nbParties++;
                    lbxHistorique.BeginUpdate(); //On ajoute le mot dans l'historique !
                    nbEssaisPrecedents++;
                    lbxHistorique.Items.Add("Partie " + nbParties + " - " + motATrouver + " - Perdue - " + nbEssaisPrecedents + " coups");
                    lbxHistorique.EndUpdate();

                    nouvellePartie();
                }
                else if (result == DialogResult.No)
                {
                    this.Dispose();
                }
            }
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            nbParties++;
            lbxHistorique.BeginUpdate(); //On ajoute le mot dans l'historique !
            lbxHistorique.Items.Add("Partie " + nbParties + " - " + motATrouver + " - Perdue - " + nbEssaisPrecedents + " coups");
            lbxHistorique.EndUpdate();

            nouvellePartie();
        }

        private void btnTester_Click(object sender, EventArgs e)
        {
            String motPropose = txtbxPropo.Text;

            if (motPropose == "")
            {
                MessageBox.Show("Veuillez saisir un mot !", "ERREUR !");
            }
            else
            {
                if (motPropose == motATrouver) //Si le mot est le bon, l'afficher, sinon afficher le mot qui était à trouver et demande de rejouer
                {
                    motCorrect();
                }
                else if (motPropose != motATrouver)
                {
                    motIncorrect(motPropose);
                }
            }



        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            const string message =
            "T'es vraiment sûr de quitter là ?";
            const string caption = "TU VEUX VRM QUITTER";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

    }
}