using System.Security.Cryptography;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Authenticators;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace appSlam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (mailInput.Text != "" && passwordInput.Text != "")
            {
                try
                {

                var client = new RestClient("https://s4-8003.nuage-peda.fr/slam/public/api/");
                var request = new RestRequest("authentication_token", Method.Post);
                request.AddJsonBody(new { email = mailInput.Text, password = passwordInput.Text });
                var response = client.ExecuteAsync(request);
                string rawResponse = response.Result.Content;

                var token = JsonConvert.DeserializeObject<Dictionary<string, object>>(rawResponse)["token"].ToString();

                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur d'authentification");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer votre email et votre mot de passe");
            }
        }
    }
}