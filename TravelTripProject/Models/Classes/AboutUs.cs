using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Explanation { get; set; }
    }
}