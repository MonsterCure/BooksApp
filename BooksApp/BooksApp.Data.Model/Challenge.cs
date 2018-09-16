using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class Challenge
    {
        [Key]
        public int ChallengeId { get; set; }

        public int UserId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ChallengeStarted { get; set; }

        public List<Book> ChallengeBooks { get; set; }
    }
}
