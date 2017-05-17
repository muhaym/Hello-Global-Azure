using Xamarin.Forms;

namespace HelloGlobalAzure
{
	public partial class HelloGlobalAzurePage : ContentPage
	{
		public HelloGlobalAzurePage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(myName.Text))
				return;
			else if (string.IsNullOrWhiteSpace(myEmail.Text))
				return;
			else
			{
				//CurrentPlatform.Init();
				User myUser = new User();
				myUser.Name = myName.Text;
				myUser.Email = myEmail.Text;
				await Service.MobileService.GetTable<User>().InsertAsync(myUser);
				await DisplayAlert("Success", "Peru chertind", "Ok Mone");
			}	
		}
	}
}
