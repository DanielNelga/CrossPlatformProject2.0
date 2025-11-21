using System.Text.Json;
namespace CrossPlatformProject
{
    public partial class MainPage : ContentPage
    {
        string jsonFileGithub = "https://raw.githubusercontent.com/DonH-ITS/jsonfiles/refs/heads/main/moviesemoji.json";
        string localCache = Path.Combine(FileSystem.AppDataDirectory, "movies.json");

        List<Movie> allMovies = new List<Movie>();

        public MainPage()
        {
            InitializeComponent();
        }

       
    }
}
