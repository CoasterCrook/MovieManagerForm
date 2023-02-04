using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieManagerApplication
{
	// This is a comment created, im testing gitbash!
	
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}
		private void Main_Load(object sender, EventArgs e)
		{
			string connectionString = GetConnectionString();
			List<Movie> movies = new List<Movie>();
			string sqlCommand = "SELECT  Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title";
			string[] genres = {"", "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western"};

			try
			{
				using (SqlConnection connection = new SqlConnection(GetConnectionString()))
				{
					using (SqlCommand command = new SqlCommand(sqlCommand, connection))
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								var movie = new Movie();
							
								movie.Title = reader.GetString(0);
								movie.Year = reader.GetInt32(1);
								movie.Director = reader.GetString(2);

								int genreNumber = reader.GetInt32(3);
								movie.Genre = genres[genreNumber];
								
								if (!reader.IsDBNull(4))
									movie.RottenTomatoesScore = reader.GetInt32(4);

								if (!reader.IsDBNull(5))
									movie.TotalEarned = reader.GetDecimal(5);

								movies.Add(movie);
							}
						}
						connection.Close();

						dgvMovies.DataSource = movies;
						dgvMovies.Columns["TotalEarned"].DefaultCellStyle.Format = "C";
						dgvMovies.Columns["RottenTomatoesScore"].Width = 130;


					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Database connection failed. Error {ex.Message}");
			}
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnAbout_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			string sqlstm = "SELECT Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title";
			SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, GetConnectionString());
			DataSet ds = new();
			SDA.Fill(ds, "Movies");
			dgvMovies.Columns["TotalEarned"].DefaultCellStyle.Format = "C";
			dgvMovies.Columns["RottenTomatoesScore"].Width = 130;
			dgvMovies.DataSource = ds.Tables[0];
		}

		public string GetConnectionString()
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

			builder.DataSource = @"coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433";
			builder.InitialCatalog = "CSCI1630";
			builder.UserID = "rw1630";
			builder.Password = "Project!";

			return builder.ConnectionString;
		}

		private void btnAddMovie_Click(object sender, EventArgs e)
		{
			AddMovie addMovie = new AddMovie();
			addMovie.ShowDialog();
		}
	}
}