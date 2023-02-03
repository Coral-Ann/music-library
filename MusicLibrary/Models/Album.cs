using System;
namespace MusicLibrary.Models
{
	public class Album
	{
		public required string Title { get; set; }
		public Artist? Artist { get; set; }
	}
}