namespace LapTech.Models
{
    public class Laptop
    {
        public int Fps { get; set; }

        public string RAM { get; set; }

        public int Storage { get; set; }

        public int Hertz { get; set; }

        public int Vægt { get; set; }

        public string ManufacturerL { get; set; }

        public string Spi { get; set; }

        public double GamerRating { get; set; }

        GPU GPU { get; set; }
        CPU CPU { get; set; }

    }
}
