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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            usersLabel.Text = "";
            afficher_utilisateur();
        }

        private async void btOK_Click(object sender, EventArgs e)
        {
            if (comboBoxAction.Text == "Supprimer")
            {
                try
                {
                var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                var request= new RestRequest("utilisateurs/"+idUtilisateurInput.Text, Method.Delete);

                var responseUtilisateur = await client.ExecuteAsync(request);

                labelResultatAction.Text = "utilisateur supprimé";
                }
                catch (Exception f)
                {
                    Console.WriteLine("{0} Exception caught.", f);
                }

                afficher_utilisateur();
            }
            else if (comboBoxAction.Text == "Modifier")
            {
                UsersModif usersModif = new UsersModif(int.Parse(idUtilisateurInput.Text));
                this.Hide();
                usersModif.Show();
            }

            else if (comboBoxAction.Text == "Afficher")
            {
                UsersAffiche usersAffiche = new UsersAffiche(idUtilisateurInput.Text);
                this.Hide();
                usersAffiche.Show();
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void afficher_utilisateur()
        {
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
                    usersLabel.Text += "L'id est : " + item.id + " Le nom est : " + item.nom + " Le prénom est : " + item.prenom + "\n";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
