using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManagerApplication
{
	public partial class AddMovie : Form
	{
		Main main =	new Main();
		public AddMovie()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(main.GetConnectionString()))
			{
				using (SqlCommand command = new SqlCommand("INSERT INTO Movies(Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned) " + "VALUES (@Title,  @Year , @Director, @Genre, @RottenTomatoesScore, @TotalEarned)", connection))
				{
					command.Parameters.AddWithValue("@Title", txtMovieTitle.Text);
					command.Parameters.AddWithValue("@Year", txtYear.Text);
					command.Parameters.AddWithValue("@Director", txtDirector.Text);
					command.Parameters.AddWithValue("@Genre", cmbBoxGenre.SelectedIndex);
					command.Parameters.AddWithValue("@RottenTomatoesScore", txtRottenScore.Text);
					command.Parameters.AddWithValue("@TotalEarned", txtEarnings.Text);

					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();
				}
			}
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDirector.Text = "";
			txtEarnings.Text = "";
			txtMovieTitle.Text = "";
			txtRottenScore.Text = "";
			txtYear.Text = "";
			cmbBoxGenre.Text = "";
		}
	}
}
