using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchAPI.Models.DTO
{
    public class WatchDto
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Img { get; set; }
    }
}