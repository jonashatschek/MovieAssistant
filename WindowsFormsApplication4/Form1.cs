using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace WindowsFormsApplication4
{
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

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] linesInFormatsFile =
                System.IO.File.ReadAllLines(
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

        /*
        static async Task RunAsync()
        {
            Movie movie = new Movie();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            movie = await GetMovieAsync(searchString);

            //Console.WriteLine(returnMovie);

            //var test = returnMovie;

        }

        static async Task<Movie> GetMovieAsync(string path)
        {
            Movie movie = null;
            HttpResponseMessage response = await client.GetAsync(path);
            //var response = client.GetAsync(path).Result;
            //var movieObject = "";
            //string res = "";

            //using (HttpContent content = response.Content)
            //{
            //    Task<string> result = content.ReadAsStringAsync();
            //    res = result.Result;
            //    JObject test;
            //    //var movieObject = JObject.Parse(test);
            //}
            if (response.IsSuccessStatusCode)
            {
                movie = await response.Content.ReadAsAsync<Movie>();
            }

            return movie;
            //return res;
        }
            */


        #region cleaners and debug

        /// <summary>
        /// Formats the query and path correctly for searchig OMDB
        /// </summary>
        /// <param name="searchQuery"></param>
        /// <returns>query and path part of search string</returns>
        private string QueryAndPath(string searchQuery)
        {

            searchQuery = searchQuery.Replace(" ", "+");
            searchQuery = "t=" + searchQuery;
            return apiKey + searchQuery;

        }

        private string cleanInput(string input)
        {
            input = input.ToLower();
            input = input.Replace('.', ' ');
            input = input.Trim();
            //input = RemoveMovieFormatsFromInput(input);

            return input;
        }

        private string RemoveMovieFormatsFromInput(string input)
        {
            foreach (string format in listOfFormats)
            {
                if (input.Contains(format))
                {
                    int first = input.IndexOf(format);
                    int last = input.LastIndexOf(format) + format.Length;

                    //string test = input.Substring(first, last - first);
                    input = input.Replace(input.Substring(first, last - first), "");
                    input = input.Trim();
                }
            }

            return input;
        }

/*        private void debugOutput(string strDebuxText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebuxText + Environment.NewLine);
                resultsListbox.Text = resultsListbox.Text + strDebuxText + Environment.NewLine;
                resultsListbox.sele = response_textBox.TextLength;
                response_textBox.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
            }
        }*/


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

        private void searchOmdbBtn_Click(object sender, EventArgs e)
        {
            //TODO: create try-catch for when there's no internet connection
            //string selectedListboxItem = resultsListbox.SelectedItem.ToString();
            searchString = QueryAndPath(resultsListbox.SelectedItem.ToString());
            //searchString = QueryAndPath(selectedListboxItem);

            RestClient rClient = new RestClient();
            rClient.endPoint = searchString;
            string jSonString = rClient.makeRequest();

            Movie m = JsonConvert.DeserializeObject<Movie>(jSonString);

            if (m.Response != "False")
            {
                movieTitleDisplay_textbox.Text = m.Title;
                yearDisplay_textbox.Text = m.Year;
                runtimeDisplay_textbox.Text = m.Runtime;
                plotDisplay_textbox.Text = m.Plot;
                imdbRating_textbox.Text = "IMDb rating: " + m.imdbRating;
                boxOfficeDisplay_textbox.Text = "Box office: " + m.BoxOffice;
                moviePosterDisplay_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                genreDisplay_textbox.Text = "Genre: " + m.Genre;

                try
                {
                    moviePosterDisplay_picturebox.Load(m.Poster);
                }
                catch
                {
                    moviePosterDisplay_picturebox.Load("https://i.imgur.com/PBOJR40.jpg");
                }

            }
            else
                movieTitleDisplay_textbox.Text = "Movie not found :(";

        }

        #endregion
    }

}

    
