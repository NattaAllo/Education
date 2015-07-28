using System;

namespace Domain
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}