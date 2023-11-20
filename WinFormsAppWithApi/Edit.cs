using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace WinFormsAppWithApi
{
    public partial class Edit : Form
    {
        private int _id;
        public Edit(int Id,
                    string Name,
                    string Brand,
                    string ImageUrl,
                    decimal Price)
        {
            InitializeComponent();
            _id = Id;
            brand.Text = Brand;
            name.Text = Name;
            imageurl.Text = ImageUrl;
            price.Text = Price.ToString();
        }

        private void Ecancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Esave_Click(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Id = _id,
                Brand = brand.Text.ToString(),
                Name = name.Text.ToString(),
                Price = decimal.Parse(price.Text),
                ImageUrl = imageurl.Text.ToString()
            };

            var json = JsonConvert.SerializeObject(car);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var Client = new HttpClient();
            var response = await Client.PutAsync("https://localhost:44343/api/Cars/Edit", data);
            var result = await response.Content.ReadAsStringAsync();
            this.Close();
            MessageBox.Show("Edided!");
        }

        private async void Edelete_Click(object sender, EventArgs e)
        {
            using var Client = new HttpClient();
            var response = await Client.DeleteAsync($"https://localhost:44343/api/Cars/Delete/{_id}");
            var result = await response.Content.ReadAsStringAsync();
            this.Close();
            MessageBox.Show("Deleted!");
        }
    }
}
