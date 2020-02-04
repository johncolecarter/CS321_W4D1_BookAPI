using System;
using System.ComponentModel.DataAnnotations;

namespace CS321_W4D1_BookAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string OriginalLanguage { get; set; }

        public string Genre { get; set; }

        public int PublicationYear { get; set; }


        [Required]
        public int AuthorId { get; set; }

        public Author Author { get; set; }


        [Required]
        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }
    }
}
