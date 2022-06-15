using GigHub3.Models;
using System;
using System.Collections.Generic;

namespace GigHub3.ViewModel
{
    public class GigFormVM
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public DateTime DateTime => DateTime.Parse(string.Format("{0} {1}", Date, Time));
    }
}