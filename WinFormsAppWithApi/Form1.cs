using Newtonsoft.Json;

namespace WinFormsAppWithApi;

public partial class Form1 : Form
{
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
}