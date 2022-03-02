		using System.ComponentModel.DataAnnotations;
		
		namespace RazorPagesMusic.Models
		{
		    public class Music
		    {
		        public int ID { get; set; }
		        public string NameofArtists { get; set; } = string.Empty;
		
		        [DataType(DataType.Date)]
		        public DateTime MusicReleaseDate { get; set; }
		        public string MusicGenre { get; set; } = string.Empty;
		        public decimal Review { get; set; }
		    }
		}
		