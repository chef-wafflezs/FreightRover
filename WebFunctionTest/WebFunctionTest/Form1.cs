using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Collections.Generic;
using System.Web.Helpers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WebFunctionTest
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var usernamePassword = new Dictionary<string, string>
                {
                    {"grant_type", "password"},
                    {"client_id", "123456"},
                    {"username", "sysadmin"},
                    {"password", "Fr3ightR0ver!"}
                };

                var content = new FormUrlEncodedContent(usernamePassword);

                var response = await client.PostAsync("http://api.dev.freightrover.com/token", content);

                var responseString = await response.Content.ReadAsStringAsync();
                dynamic tokenObject = JsonConvert.DeserializeObject(responseString);

                var accessToken = tokenObject.access_token.Value;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", accessToken);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

                var triggerReponse = await client.GetAsync("http://api.dev.freightrover.com/Triggers/RunSaveSearchNotifier");
                if (triggerReponse.IsSuccessStatusCode)
                {
                    var x = "y";
                }
                else
                {
                    var y = "x";
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
