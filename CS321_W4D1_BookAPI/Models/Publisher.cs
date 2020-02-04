using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CS321_W4D1_BookAPI.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int FoundedYear { get; set; }

        public string CountryOfOrigin { get; set; }

        public string HeadQuartersLocation { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}

