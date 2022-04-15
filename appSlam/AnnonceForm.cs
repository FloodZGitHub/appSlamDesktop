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
    public partial class AnnonceForm : Form
    {
        public List<Annonce> newAnnonce;

        public AnnonceForm()
        {
            InitializeComponent();
            annoncetext.Text = "";

            try
            {
                RefreshList();
                
                if (newAnnonce == null)
                {
                    annoncetext.Text = "Annonce non trouvé ou aucune annonce existante";
                    annoncetext.Text = "";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                annoncetext.Text = "Annonce non trouvé";
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                AnnonceModif annonceModif = new AnnonceModif((Annonce)listView1.SelectedItems[0].Tag);
                if (annonceModif.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                }
            }
        }

    private void RefreshList()
        {
            var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

            var request = new RestRequest("annonces", Method.Get);


            var response = client.ExecuteAsync(request);

            string rawResponse = response.Result.Content;

            List<Annonce> newAnnonce = JsonConvert.DeserializeObject<List<Annonce>>(rawResponse);

            this.newAnnonce = newAnnonce;

            listView1.Items.Clear();
            foreach (Annonce item in newAnnonce)
            {
                string[] myDifferenceElement = new string[5] { "", "", "", "", "" };
                myDifferenceElement[0] = item.id.ToString();
                myDifferenceElement[1] = item.designation;
                myDifferenceElement[2] = item.designation;
                myDifferenceElement[3] = item.prix.ToString();
                myDifferenceElement[4] = item.nom;
                ListViewItem myItem = new ListViewItem(myDifferenceElement);
                myItem.Tag = item;
                listView1.Items.Add(myItem);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                Annonce Supp = (Annonce)listView1.SelectedItems[0].Tag;
                var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                var request = new RestRequest("annonces/" + Supp.id, Method.Delete);

                var responseUtilisateur = client.ExecuteAsync(request);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
