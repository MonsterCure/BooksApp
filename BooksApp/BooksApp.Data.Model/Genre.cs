using System.ComponentModel.DataAnnotations;

namespace BooksApp.Data.Model
{
    public enum Genre
    {
        Unspecified = 0,

        Art = 1,

        Biography = 2,

        Business = 3,

        [Display(Name ="Chick Lit")]
        ChickLit = 4,

        [Display(Name ="Children's")]
        Childrens = 5,

        Christian = 6,

        Classics = 7,

        Comics = 8,

        Contemporary = 9,

        Crime = 10,

        Fantasy = 11,

        Fiction = 12,

        [Display(Name ="Gay and Lesbian")]
        GayAndLesbian = 13,
        
        [Display(Name ="Graphic Novels")]
        GraphicNovels = 14,

        [Display(Name ="Historical Fiction")]
        HistoricalFiction = 15,

        History = 16,

        Horror = 17,

        [Display(Name ="Humor and Comedy")]
        HumorAndComedy = 18,

        Manga = 19,

        Memoir = 20,

        Music = 21,

        Mystery = 22,

        Nonfiction = 23,

        Paranormal = 24,

        Philosophy = 25,

        Poetry = 26,

        Psychology = 27,

        Religion = 28,

        Romance = 29,

        Science = 30,
        
        [Display(Name ="Science Fiction")]
        ScienceFiction = 31,

        [Display(Name ="Self Help")]
        SelfHelp = 32,

        Suspense = 33,

        Spirituality = 34,

        Sports = 35,

        Thriller = 36,

        Travel = 37,

        [Display(Name ="Young Adult")]
        YoungAdult = 38
    }
}
