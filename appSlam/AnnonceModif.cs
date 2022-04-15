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
    public partial class AnnonceModif : Form
    {
        Annonce annonceToEdit;
        public AnnonceModif(Annonce annonceToEdit)
        {
            InitializeComponent();
            this.annonceToEdit = annonceToEdit;

            textBoxPrix.Text = annonceToEdit.prix;
            textBoxCP.Text = annonceToEdit.codepostal;
            textBoxDescirption.Text = annonceToEdit.description;
            textBoxDesignation.Text = annonceToEdit.designation;
            textBoxMail.Text = annonceToEdit.mail;
            textBoxNom.Text = annonceToEdit.nom;
            textBoxRegion.Text = annonceToEdit.region;
            textBoxTel.Text = annonceToEdit.telephone;
            textBoxVille.Text = annonceToEdit.ville;
            Console.WriteLine("test111");
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if(textBoxPrix.Text != "" && textBoxCP.Text != "" && textBoxDescirption.Text != "" && textBoxDesignation.Text != "" && textBoxMail.Text != "" && textBoxNom.Text != "" && textBoxRegion.Text != "" && textBoxTel.Text != "" && textBoxVille.Text != "")
            {
                annonceToEdit.prix = textBoxPrix.Text;
                annonceToEdit.description = textBoxDescirption.Text;
                annonceToEdit.mail = textBoxMail.Text;
                annonceToEdit.nom = textBoxNom.Text;
                annonceToEdit.telephone = textBoxTel.Text;
                annonceToEdit.codepostal = textBoxCP.Text;
                annonceToEdit.designation = textBoxDesignation.Text;
                annonceToEdit.region = textBoxRegion.Text;
                annonceToEdit.ville = textBoxVille.Text;

                var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api");

                var request = new RestRequest("utilisateurs/" + annonceToEdit.id, Method.Put);

                request.AddJsonBody(annonceToEdit);

                var response = client.ExecuteAsync(request);

                var rawResponse = response.Result.Content;
            }
        }
    }
}