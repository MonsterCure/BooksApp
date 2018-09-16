using System.ComponentModel.DataAnnotations;

namespace BooksApp.Data.Model
{
    public enum BookFormat
    {
        Unspecified = 0,

        Paperback = 1,

        Hardback = 2,

        [Display(Name="E-book")]
        EBook = 3
    }
}
