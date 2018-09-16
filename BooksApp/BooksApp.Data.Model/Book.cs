using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public string BookDescription { get; set; }

        public int BookCoverId { get; set; }

        public BookCover BookCover { get; set; }

        public string ISBN { get; set; }

        public string Publisher { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Published { get; set; }

        public BookFormat BookFormat { get; set; }

        public Genre Genre { get; set; }

        public List<Author> Authors { get; set; }

        public bool IsPartOfSeries { get; set; }

        public int? SeriesId { get; set; }

        public Series Series { get; set; }

        public short? NumberInSeries { get; set; }
    }
}
