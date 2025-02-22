﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST2.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        //Geolocation
        public double Longitude { get; set; } = 0.00;
        public double Latitude { get; set; } = 0.00;
    }
}
