using System.Data;
using System.Data.SqlClient;

namespace MovieManagerApplication
{
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
									movie.RottenScore = reader.GetInt32(4);
								if (!reader.IsDBNull(5))
								{
									decimal totalEarned = reader.GetDecimal(5);
									movie.TotalEarned = totalEarned.ToString("C");
								}

								movies.Add(movie);
							}
						}
						connection.Close();

						dgvMovies.DataSource = movies;
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
		//git test
		private static string GetConnectionString()
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

			builder.DataSource = @"coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433";
			builder.InitialCatalog = "CSCI1630";
			builder.UserID = "rw1630";
			builder.Password = "Project!";

			return builder.ConnectionString;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			refresh();
		}

		public void refresh()
		{
			string sqlstm = "Select * from Movies";
			SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, GetConnectionString());
			DataSet ds = new();
			SDA.Fill(ds, "Movies");
			dgvMovies.DataSource = ds.Tables[0];
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}
	}
}