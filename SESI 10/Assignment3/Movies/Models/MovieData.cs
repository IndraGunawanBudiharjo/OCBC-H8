using System.Globalization;

namespace Movies.Models 
{
    public class MovieData
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Genre {get; set;}
        public string Duration {get; set;}
        public System.DateTime ReleaseDate {get; set;}
    }
}