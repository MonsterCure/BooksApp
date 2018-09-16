using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class Series
    {
        [Key]
        public int SeriesId { get; set; }

        public string SeriesTitle { get; set; }

        public List<Book> Books { get; set; }
    }
}
