using System;
using System.Collections.Generic;
using CS321_W4D1_BookAPI.Models;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public class PublisherModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int FoundedYear { get; set; }

        public string CountryOfOrigin { get; set; }

        public string HeadQuartersLocation { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}

