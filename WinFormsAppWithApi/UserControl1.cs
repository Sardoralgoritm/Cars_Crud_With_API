namespace WinFormsAppWithApi;

public partial class UserControl1 : UserControl
{
    private int id;
    Car car {  get; set; }
    public UserControl1(int Id,
                        string Brand,
                        string Name,
                        decimal Price,
                        string Imageurl)
    {
        InitializeComponent();
        brand.Text += Brand;
        name.Text += Name;
        price.Text += Price;
        picture.ImageLocation = Imageurl;
        id = Id;

        car = new ()
        {
            Id = Id,
            Brand = Brand,
            Name = Name,
            Price = Price,
            ImageUrl = Imageurl
        };


    }

    private void UserControl1_DoubleClick(object sender, EventArgs e)
    {
        Edit edit = new(car.Id,
                        car.Name,
                        car.Brand,
                        car.ImageUrl,
                        car.Price);

        edit.ShowDialog();
    }
}
