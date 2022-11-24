using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagerApplication
{
	public class Movie
	{
		//SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title
		public string Title { get; set; }
		public int Year { get; set; }
		public string Director { get; set; }
		public string Genre { get; set; }
		public int RottenTomatoesScore { get; set; }
		public decimal TotalEarned { get; set; }
	}
}
