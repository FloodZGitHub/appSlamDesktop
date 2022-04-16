using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace appSlam
{
    public partial class UsersModif : Form
    {
        Utilisateur utilisateurToEdit;
        public UsersModif(Utilisateur utilisateurToEdit)
        {
            InitializeComponent();
            this.utilisateurToEdit = utilisateurToEdit;

            idUtilisateurLabel.Text = utilisateurToEdit.id.ToString();
            nomInput.Text = utilisateurToEdit.nom;
            prenomInput.Text = utilisateurToEdit.prenom;
            inscriptionDateLabel.Text = utilisateurToEdit.dateinscription;
            equipageInput.Text = utilisateurToEdit.nomEquipage;
        }

        private void UsersModif_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nomInput.Text != "" && prenomInput.Text != "" && equipageInput.Text != "")
            {
                utilisateurToEdit.nom = nomInput.Text;
                utilisateurToEdit.prenom = prenomInput.Text;
                utilisateurToEdit.nomEquipage = equipageInput.Text;

                var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                var request = new RestRequest("utilisateurs/" + utilisateurToEdit.id, Method.Put);

                request.AddJsonBody(utilisateurToEdit);

                var response = client.ExecuteAsync(request);

                var rawResponse = response.Result.Content;

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }

            this.Close();
        }
    }
}
