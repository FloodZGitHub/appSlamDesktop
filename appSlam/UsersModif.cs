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
        public UsersModif(int idUtilisateur)
        {
            InitializeComponent();
            
            try
            {
                var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                var request = new RestRequest("utilisateurs", Method.Get);

                var response = client.ExecuteAsync(request);

                string rawResponse = response.Result.Content;

                List<Utilisateur> newUtilisateur = JsonConvert.DeserializeObject<List<Utilisateur>>(rawResponse);

                foreach (var item in newUtilisateur)
                {
                    if (item.id == idUtilisateur)
                    {
                        idUtilisateurLabel.Text = item.id.ToString();
                        nomInput.Text = item.nom;
                        prenomInput.Text = item.prenom;
                        inscriptionDateLabel.Text = item.dateinscription;
                        equipageInput.Text = item.nomEquipage;
                    }
                }
                if (idUtilisateurLabel.Text == "")
                {
                    idUtilisateurLabel.Text = "Utilisateur non trouvé";
                }

            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message);
                idUtilisateurLabel.Text = "Utilisateur non trouvé";
            }
        }

        private void UsersModif_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            this.Close();
            this.Dispose();
            usersForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nomInput.Text != "" && prenomInput.Text != "" && equipageInput.Text != "")
            {

                try
                {
                    var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                    var request = new RestRequest("utilisateurs", Method.Get);

                    var response = client.ExecuteAsync(request);

                    string rawResponse = response.Result.Content;

                    List<Utilisateur> newUtilisateur = JsonConvert.DeserializeObject<List<Utilisateur>>(rawResponse);

                    Utilisateur utilisateurInput = new Utilisateur();
                    utilisateurInput.id = Int16.Parse(idUtilisateurLabel.Text);
                    utilisateurInput.nom = nomInput.Text;
                    utilisateurInput.prenom = prenomInput.Text;
                    utilisateurInput.dateinscription = inscriptionDateLabel.Text;
                    utilisateurInput.nomEquipage = equipageInput.Text;

                    foreach (var item in newUtilisateur)
                    {
                        if (item.id == Int16.Parse(idUtilisateurLabel.Text))
                        {
                            foreach(var annonce in item.annonces)
                            {
                                utilisateurInput.annonces.Append(annonce);
                            }
                            foreach(var messageEnvoi in item.messageenvoi)
                            {
                                utilisateurInput.messageenvoi.Append(messageEnvoi);
                            }
                            foreach (var messageRecu in item.messagerecu)
                            {
                                utilisateurInput.messagerecu.Append(messageRecu);
                            }
                            utilisateurInput.user = item.user;
                        }
                    }
                        
                    client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                    request = new RestRequest("utilisateurs/" + idUtilisateurLabel.Text, Method.Put);

                    request.AddJsonBody(utilisateurInput);


                    response = client.ExecuteAsync(request);

                    rawResponse = response.Result.Content;

                    MessageBox.Show(rawResponse);

                    UsersForm usersForm = new UsersForm();
                    this.Close();
                    this.Dispose();
                    usersForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }
    }
}
