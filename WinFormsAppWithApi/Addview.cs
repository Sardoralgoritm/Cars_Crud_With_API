using Newtonsoft.Json;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsAppWithApi
{
    public partial class Addview : Form
    {
        HttpClient client = new();
        public Addview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Brand = brand.Text,
                Name = name.Text,
                Price = Decimal.Parse(price.Text),
                ImageUrl = imageurl.Text,
            };

            var json = JsonConvert.SerializeObject(car);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var response = await client.PostAsync("https://localhost:44343/api/Cars/create", data);
            var result = await response.Content.ReadAsStringAsync();
            this.Close();
            MessageBox.Show("Qo`shildi");
        }
    }
}
