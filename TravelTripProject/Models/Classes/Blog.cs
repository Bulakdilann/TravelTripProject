using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Display(Name = "Tarih")]
        public DateTime Date { get; set; }
        [Display(Name = "Açıklama")]
        public string Explanation { get; set; }
        [Display(Name = "Blog Resmi")]
        public string BlogImage { get; set; }

        // relationships
        public ICollection<Comments> Comments { get; set; }
    }
}