using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public TacoBell(string[] cells)
        {
            double latitude = Double.Parse(cells[0]);
            double longitude = Double.Parse(cells[1]);
            Location = new Point(latitude, longitude);
            cells[2] = cells[2].Replace(" (Free trial * Add to Cart for a full POI info)", "");
            cells[2] = cells[2].Replace("Taco Bell ", "");
            cells[2] = cells[2].Replace(".", "");
            cells[2] = cells[2].Replace("/", "");
            Name = cells[2];
        }
        public string Name { get; set; }
        public Point Location { get; set; }
    }   
}
