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
            afficher_utilisateur();
        }

        private async void btOK_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                Utilisateur utilisateur = (Utilisateur)listView1.SelectedItems[0].Tag;

                if (comboBoxAction.Text == "Supprimer")
                {
                    try
                    {
                        var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                        var request = new RestRequest("utilisateurs/" + utilisateur.id, Method.Delete);

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
                    if (listView1.SelectedItems.Count != 0)
                    {
                        UsersModif userModif = new UsersModif((Utilisateur)listView1.SelectedItems[0].Tag);
                        userModif.ShowDialog();
                    }
                }

                else if (comboBoxAction.Text == "Afficher")
                {
                    UsersAffiche usersAffiche = new UsersAffiche(utilisateur.id);
                    this.Hide();
                    usersAffiche.Show();
                }
                else if (comboBoxAction.Text == "Rafraichir")
                {
                    afficher_utilisateur();
                }
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
            try
            {
                var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                var request = new RestRequest("utilisateurs", Method.Get);

                var response = client.ExecuteAsync(request);

                string rawResponse = response.Result.Content;

                List<Utilisateur> newUtilisateur = JsonConvert.DeserializeObject<List<Utilisateur>>(rawResponse);

                listView1.Items.Clear();
                foreach (var item in newUtilisateur)
                {
                    string[] myDifferenceElement = new string[5] { "", "", "", "", "" };
                    myDifferenceElement[0] = item.id.ToString();
                    myDifferenceElement[1] = item.nom;
                    myDifferenceElement[2] = item.prenom;
                    myDifferenceElement[3] = item.dateinscription;
                    myDifferenceElement[4] = item.nomEquipage;
                    ListViewItem myItem = new ListViewItem(myDifferenceElement);
                    myItem.Tag = item;
                    listView1.Items.Add(myItem);
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
