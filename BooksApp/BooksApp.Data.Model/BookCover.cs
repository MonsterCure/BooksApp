using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class BookCover
    {
        [Key]
        public int BookCoverId { get; private set; } // private set ???

        //[Column(TypeName = "image")]
        public byte[] BookCoverImage { get; set; }

        //modelBuilder.Entity<BookCover>().Property(bc => bc.BookCover).HasColumnName("yourColumnName").HasMaxLength(SomeLength).HasColumnType("varbinary");  //HasColumnType("image")
    }
}
