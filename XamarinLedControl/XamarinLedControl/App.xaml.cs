using Xamarin.Forms;
using XamarinLedControl.View;

namespace XamarinLedControl
{
    public partial class App : Application
    {
        public App()
        {
			//InitializeComponent();
			MainPage=GetMainPage();

	            //InitializeComponent();
	            //The Root page of your application
				//MainPage = new BlankPage();
        }
		public static Page GetMainPage()
		{
			return new ContentPage
			{
				Content = new Label
				{
					Text = "Hello, Forms!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
