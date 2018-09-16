using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Model
{
    public class AuthorImage
    {
        public int AuthorImageId { get; set; }

        //[Column(TypeName = "image")]
        public byte[] AuthorImageFile { get; set; }

        //modelBuilder.Entity<AuthorImage>().Property(bc => bc.AuthorImageFile).HasColumnName("yourColumnName").HasMaxLength(SomeLength).HasColumnType("varbinary");   //[Column(TypeName = "image")]
    }
}
