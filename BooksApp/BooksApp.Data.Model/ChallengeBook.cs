using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class ChallengeBook
    {
        [Key]
        public int ChallengeBookId { get; set; }

        public int ChallengeId { get; set; }

        public int BookId { get; set; }
    }
}
