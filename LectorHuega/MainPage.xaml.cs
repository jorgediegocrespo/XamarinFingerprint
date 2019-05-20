namespace LectorHuega
{
    using Plugin.Fingerprint;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnAuthenticate_Clicked(object sender, System.EventArgs e)
        {
            var result = await CrossFingerprint.Current.AuthenticateAsync("Tap that fingerprint sensor!");
            if (result.Authenticated)
            {
                LblResult.Text = "VALID fingerprint";
                LblResult.TextColor = Color.Green;
            }
            else
            {
                LblResult.Text = "INVALID fingerprint";
                LblResult.TextColor = Color.Red;
            }
        }
    }
}
