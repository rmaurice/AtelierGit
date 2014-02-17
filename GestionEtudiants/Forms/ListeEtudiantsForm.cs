using GestionEtudiants.Database;
using System;
using System.Windows.Forms;

namespace GestionEtudiants.Forms
{
    public partial class ListeEtudiantsForm : Form
    {
        public ListeEtudiantsForm()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // TODO: Ouvre la fenêtre de création d'un étudiant
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lstEtudiants.SelectedIndex > -1)
            {
                // TODO: Ouvre la fenêtre de modification d'un étudiant
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstEtudiants.SelectedIndex > -1)
            {
                DialogResult a = MessageBox.Show("Supprimer l'étudiant sélectionné ?", "Supprimer un étudiant", MessageBoxButtons.YesNo);

                if (a == DialogResult.Yes)
                {
                    // TODO: Supprimer l'étudiant sélectionné
                }
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            lstEtudiants.DataSource = EtudiantsDbAccess.Instance.Get();
        }
    }
}