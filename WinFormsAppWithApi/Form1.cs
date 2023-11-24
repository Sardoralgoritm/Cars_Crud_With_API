using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace WinFormsAppWithApi;

public partial class Form1 : Form
{
    private int index = 1;
    HttpClient client = new();
    public Form1()
    {
        InitializeComponent();
    }

    private async void RefreshBtn_Click(object sender, EventArgs e)
    {
        var json = await client.GetStringAsync("https://localhost:44343/api/Cars/GetAllCars");
        var cars = JsonConvert.DeserializeObject<List<Car>>(json);

        body.Controls.Clear();
        foreach (var car in cars)
        {
            UserControl1 userControl = new(car.Id,
                                           car.Brand,
                                           car.Name,
                                           car.Price,
                                           car.ImageUrl);

            body.Controls.Add(userControl);
        }
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
        Addview addview = new Addview();
        addview.ShowDialog();
    }

    private async void paged_TextChanged(object sender, EventArgs e)
    {
        var cur = paged.Text;
        if (paged.Text != "")
            index = int.Parse(paged.Text);
        var json = await client.GetStringAsync($"https://localhost:44343/api/Cars/GetPaged?numberPage={index}");
        var cars = JsonConvert.DeserializeObject<List<Car>>(json);
        body.Controls.Clear();
        foreach (Car car in cars)
        {
            UserControl1 userControl = new(car.Id,
                                           car.Brand,
                                           car.Name,
                                           car.Price,
                                           car.ImageUrl);

            body.Controls.Add(userControl);
        }
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        var json = await client.GetStringAsync("https://localhost:44343/api/Cars/GetPaged?numberPage=1");
        var cars = JsonConvert.DeserializeObject<List<Car>>(json);

        var jjson = await client.GetStringAsync("https://localhost:44343/api/Cars/GetAllCars");
        var allcars = JsonConvert.DeserializeObject<List<Car>>(jjson);
        var limit = (decimal)(allcars.Count() / 5.0);
        var ind = Math.Ceiling(limit);

        List<int> pages = new();
        for (int i = 0; i < ind; i++)
        {
            pages.Add(i + 1);
        }

        paged.DataSource = pages;

        body.Controls.Clear();
        foreach (Car car in cars)
        {
            UserControl1 userControl = new(car.Id,
                                           car.Brand,
                                           car.Name,
                                           car.Price,
                                           car.ImageUrl);

            body.Controls.Add(userControl);
        }
    }
}