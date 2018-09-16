using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class UserBookReview
    {
        [Key]
        public int UserBookId { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public bool IsRead { get; set; }

        public bool WantToRead { get; set; }

        public bool IsFavorite { get; set; }

        public DateTime ReadingStarted { get; set; }

        public DateTime ReadingEnded { get; set; }

        public byte? Rating { get; set; } // 1-5

        public string Review { get; set; }
    }
}
