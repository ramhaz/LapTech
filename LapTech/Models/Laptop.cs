namespace LapTech.Models
{
    public class Laptop
    {

        public string RAM { get; set; }

        public int Storage { get; set; }

        public required string Manufacturer { get; set; }

        public int Id { get; set; }

        public GPU GPUId { get; set; }
        public CPU CPUId { get; set; }

        public int Price { get; set; }

    }
}
