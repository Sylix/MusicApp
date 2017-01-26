using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Interfaces;
using XamarinUniversity.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace MusicApp
{
	public partial class App : Application
	{
		public enum AppPages
		{
			AlbumsPage,
			AlbumPage,
			EditAlbumPage
		}

		public App()
		{
			XamUInfrastructure.Init();

			InitializeComponent();

			MainPage = new NavigationPage(new AlbumsPage());

			var navService = DependencyService.Get<INavigationService>() as FormsNavigationPageService;
			navService?.RegisterPage(AppPages.AlbumsPage, () => new AlbumsPage());
			navService?.RegisterPage(AppPages.AlbumPage, () => new AlbumPage());
			navService?.RegisterPage(AppPages.EditAlbumPage, () => new EditAlbumPage());
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
