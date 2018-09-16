using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public interface IApplicationUser
    {
        List<UserBookReview> BookReviews { get; set; }

        List<UserBookComment> BookComments { get; set; }

        List<ApplicationUser> FollowedUsers { get; set; }

        List<Author> FavoriteAuthors { get; set; }

        List<Book> FavoriteBooks { get; set; }

        List<Book> ReadBooks { get; set; }

        List<Book> BooksToRead { get; set; }

        List<Challenge> Challenges { get; set; }
    }
}
