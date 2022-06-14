using GigHub3.Models;
using System.Collections.Generic;

namespace GigHub3.ViewModel
{
    public class GigFormVM
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}