using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class UserBookComment
    {
        [Key]
        public int UserBookCommentId { get; set; }

        public int UserBookId { get; set; }

        public UserBookReview UserBookReview { get; set; }  

        public string Comment { get; set; }
    }
}
