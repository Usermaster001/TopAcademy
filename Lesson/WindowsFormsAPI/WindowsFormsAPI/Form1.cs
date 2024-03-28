using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace WindowsFormsAPI
{
    public partial class Form1 : Form
    {
        public Response message;
        public Form1()
        {
            InitializeComponent();
        }

        private async Task button1_ClickAsync(object sender, EventArgs e)
        {
            await GetData();
            Results form = new Results(message);
            form.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1_ClickAsync(sender, e);
        }

        public async Task GetData()
        {
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization",
                "Token ");

            var response = await httpClient.PostAsJsonAsync(
                "http://suggestions.dadata.ru/suggestions/api/4_1/rs/suggest/country",
                new Request() { Query = textBox1.Text });

            message = await response.EnsureSuccessStatusCode().Content.ReadFromJsonAsync<Response>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
