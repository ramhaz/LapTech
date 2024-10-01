namespace LapTech.Models
{
    public class Laptop
    {

        public string RAM { get; set; }

        public int Storage { get; set; }

        public string Manufacturer { get; set; }

        public int Id { get; set; }

        public int GPUId { get; set; }
        public int CPUId { get; set; }

        public GPU GPU { get; set; }
        public CPU CPU { get; set; }

        public int Price { get; set; }

    }
}
