using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace WindowsFormsApplication4
{

    //TODO: Add To download and To watch lists! Make ability to save using XML

    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public partial class Form1 : Form
    {

        List<string> listOfMovies = new List<string>();
        //static HttpClient client = new HttpClient();
        private string apiKey = "?apikey=a52432a1&";
        private static string searchString;
        //private const string url = "http://www.omdbapi.com/";
        List<string> listOfFormats = new List<string>();
        List<string> watchList = new List<string>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] linesInFormatsFile =
                File.ReadAllLines(
                    @"C:\Users\Jonas\Documents\Visual Studio 2015\Projects\WindowsFormsApplication4\WindowsFormsApplication4\bin\listOfFormats.txt");

            foreach (string line in linesInFormatsFile)
            {
                string lineHolder = cleanInput(line);
                listOfFormats.Add(lineHolder);
            }

            DirectoryInfo d = new DirectoryInfo(@"X:\Filmer");

            FileInfo[] files = d.GetFiles();
            DirectoryInfo[] subdirectories = d.GetDirectories();

            foreach (FileInfo file in files)
            {
                string fileName = cleanInput(file.Name);
                listOfMovies.Add(RemoveMovieFormatsFromInput(fileName));
            }

            foreach (DirectoryInfo subdirectory in subdirectories)
            {
                string nameOfSubdirectory = cleanInput(subdirectory.Name);
                listOfMovies.Add(cleanInput(RemoveMovieFormatsFromInput(nameOfSubdirectory)));

            }

            resultsListbox.Items.AddRange(listOfMovies.ToArray());

        }

        #region cleaners and debug

        /// <summary>
        /// Formats the query and path correctly for searchig OMDB
        /// </summary>
        /// <param name="searchQuery"></param>
        /// <returns>query and path part of search string</returns>
        private string QueryAndPath(string searchQuery, string searchType)
        {

            searchQuery = searchQuery.Replace(" ", "+");

            if (searchType == "title")
            {
                searchQuery = "t=" + searchQuery;
            }
            else if (searchType == "imdbId")
            {
                searchQuery = "i=" + searchQuery;
            }

            return apiKey + searchQuery;

        }

        private string cleanInput(string input)
        {

            input = input.ToLower();
            input = input.Replace('.', ' ');
            input = input.Replace('_', ' ');
            input = input.Trim();
            //input = RemoveMovieFormatsFromInput(input);

            return input;
        }

        private string RemoveMovieFormatsFromInput(string input)
        {

            foreach (string movieFormat in listOfFormats)
            {

                if (input.Contains(movieFormat))
                {

                    int first = input.IndexOf(movieFormat);
                    int last = input.LastIndexOf(movieFormat) + movieFormat.Length;

                    //string test = input.Substring(first, last - first);
                    try
                    {

                        if (!Char.IsLetter(input[first - 1]))
                        {

                            input = input.Replace(input.Substring(first, last - first), "");
                            input = input.Trim();
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {

                        input = input.Replace(input.Substring(first, last - first), "");
                        input = input.Trim();
                    }
                }
            }

            return input;
        }

        private void MovieNotFound()
        {

            movieTitleDisplay_textbox.Text = "Movie not found :(";
            yearDisplay_textbox.Text = "-";
            runtimeDisplay_textbox.Text = "-";
            plotDisplay_textbox.Text = "-";
            imdbRating_textbox.Text = "IMDb rating: " + "-";
            boxOfficeDisplay_textbox.Text = "Box office: " + "-";
            moviePosterDisplay_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            genreDisplay_textbox.Text = "Genre: " + "-";
            moviePosterDisplay_picturebox.Load("https://i.imgur.com/PBOJR40.jpg");
        }

        #endregion


        #region UI task handlers


        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            resultsListbox.Items.Clear();

            foreach (string movie in listOfMovies.FindAll(m => m.Contains((sender as TextBox).Text)))
            {

                resultsListbox.Items.Add(movie);
            }
            //= listOfMovies.Where(m => m.Contains(sender.ToString()));
        }

        private string SearchStringToClient(string searchString)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = searchString;
            string jSonString = rClient.makeRequest();

            return jSonString;
        }

        private void searchOmdbBtn_Click(object sender, EventArgs e)
        {
            //TODO: create try-catch for when there's no internet connection
            string jSonString = "";

            if (searchOnTextboxInput_radioButton.Checked)
            {
                //searchString = QueryAndPath(searchTxtbox.Text);
                jSonString = SearchStringToClient(QueryAndPath(searchTxtbox.Text, "title"));
            }
            else
            {

                try
                {

                    jSonString = SearchStringToClient(QueryAndPath(resultsListbox.SelectedItem.ToString(), "title"));
                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("Select a movie in the list");
                }

            }

            Movie movieData = JsonConvert.DeserializeObject<Movie>(jSonString);

            try
            {
                if (movieData.Response != "False")
                {

                    movieTitleDisplay_textbox.Text = movieData.Title;
                    yearDisplay_textbox.Text = movieData.Year;
                    runtimeDisplay_textbox.Text = movieData.Runtime;
                    plotDisplay_textbox.Text = movieData.Plot;
                    imdbRating_textbox.Text = @"IMDb rating: " + movieData.imdbRating;
                    boxOfficeDisplay_textbox.Text = "Box office: " + movieData.BoxOffice;
                    moviePosterDisplay_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    genreDisplay_textbox.Text = "Genre: " + movieData.Genre;
                    moviePosterDisplay_picturebox.Load(movieData.Poster);
                    imdbIdDisplay_textbox.Text = movieData.imdbID;
                }

            }
            catch
            {
                MovieNotFound();
            }

        }

        #endregion

        private void saveToWatchlist_button_Click(object sender, EventArgs e)
        {
            //string returnJsonString = "";

            //if (movieTitleDisplay_textbox.Text != "Movie not found :(")
            //{
            //    returnJsonString = SearchStringToClient(QueryAndPath(movieTitleDisplay_textbox.Text));
            //}

            //Movie m = new Movie();

            string jsonString = "";

            jsonString = SearchStringToClient(QueryAndPath(imdbIdDisplay_textbox.Text, "imdbId"));

            Movie m = JsonConvert.DeserializeObject<Movie>(jsonString);

            //try
            //{
                if (m.Response != "False")
                {

                    //jsonString = JsonConvert.SerializeObject(jsonString.ToArray());
                    //System.IO.File.WriteAllText(@"C:\Users\Jonas\Documents\Visual Studio 2015\Projects\WindowsFormsApplication4\WindowsFormsApplication4\bin\watchList.json", jsonString);

                    using (FileStream fs = File.Open(Path.GetFullPath(@"C:\Users\Jonas\Documents\Visual Studio 2015\Projects\WindowsFormsApplication4\WindowsFormsApplication4\bin\watchList.json"), FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(fs))
                    using (JsonWriter jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(jw, m);
                    }

                }
            //}
            //catch
            //{
            //    MovieNotFound();
            //}

        }
    }

}

    
