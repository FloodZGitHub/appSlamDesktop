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
    public partial class UsersAffiche : Form
    {
        public UsersAffiche(int numeroUser)
        {
            InitializeComponent();
            usersLabel.Text = "";
            try
            {
                var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                var request = new RestRequest("utilisateurs", Method.Get);

                var response = client.ExecuteAsync(request);

                string rawResponse = response.Result.Content;

                List<Utilisateur> newUtilisateur = JsonConvert.DeserializeObject<List<Utilisateur>>(rawResponse);

                foreach (var item in newUtilisateur)
                {
                    if (item.id == numeroUser)
                    {
                        usersLabel.Text += "id : " + item.id + "\nnom : " + item.nom + "\nprénom : " 
                            + item.prenom + "\nDate Inscription : " + item.dateinscription + "\nNom équipage : " + item.nomEquipage + "\nUser : " + item.user;
                        annoncesLabel.Text ="Annonces : ";
                        foreach (var annonces in item.annonces)
                        {
                            annoncesLabel.Text += "\n";
                            annoncesLabel.Text += annonces;
                        }
                    }
                }
                if (usersLabel.Text == "")
                {
                    usersLabel.Text = "Utilisateur non trouvé";
                    annoncesLabel.Text = "";
                }

            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message);
                usersLabel.Text = "Utilisateur non trouvé";
                annoncesLabel.Text = "";
            }

        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            this.Close();
            this.Dispose();
            usersForm.Show();
        }
    }
}
