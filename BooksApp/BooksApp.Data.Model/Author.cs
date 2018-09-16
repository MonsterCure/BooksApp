using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DeathDate { get; set; }

        public string PlaceOfBirth { get; set; }

        public int AuthorImageId { get; set; }

        public AuthorImage AuthorImage { get; set; }

        public string Biography { get; set; }

        public List<Book> Books { get; set; }
    }
}
