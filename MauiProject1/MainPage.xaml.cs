namespace MauiProject1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string[] arr = new string[4];

        public MainPage()
        {
            InitializeComponent();
            arr[0] = "https://st5.depositphotos.com/1655013/63876/i/450/depositphotos_638769962-stock-photo-cute-illustration-corgi-puppy-cartoon.jpg";
            arr[1] = "https://st5.depositphotos.com/1655013/63876/i/450/depositphotos_638769962-stock-photo-cute-illustration-corgi-puppy-cartoon.jpg";
            arr[2] = "https://st5.depositphotos.com/1655013/63877/i/450/depositphotos_638770934-stock-photo-cute-illustration-corgi-puppy-cartoon.jpg";
            arr[3] = "https://cdn.pixabay.com/photo/2022/05/28/14/38/cartoon-dog-7227431_1280.png";
            theImage.Source = arr[0];
            ClickDown.IsEnabled = false;
        }

        private void ChangePhotoDown(object sender, EventArgs e)
        {
            count--;
            theImage.Source = arr[count];
            if (count == 1)
            {
                ClickDown.IsEnabled = false;
            }
            ClicUp.IsEnabled = true;

        }
        private void ChangePhotoUp(object sender, EventArgs e)
        {
            count++;
            theImage.Source = arr[count];
            if (count == arr.Length-1)
            {
                ClicUp.IsEnabled = false;
            }
            ClickDown.IsEnabled = true;
        }


    }
}