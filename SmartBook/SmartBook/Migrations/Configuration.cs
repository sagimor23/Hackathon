namespace SmartBook.Migrations
{
    using SmartBook.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<SmartBook.DAL.SmartBookWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SmartBook.DAL.SmartBookWebContext context)
        {

            List<Picture> pictures = new List<Picture>();
            pictures.Add(new Picture { PictureId = 1, PictureName = "https://m.media-amazon.com/images/M/MV5BZjU2Y2E3NGYtZTk2My00NWEzLTlhNzMtMjBmZmIzOTBlMzgxXkEyXkFqcGdeQXVyNzQwMzAwNTI@._V1_.jpg" });
            pictures.Add(new Picture { PictureId = 2, PictureName = "https://m.media-amazon.com/images/M/MV5BNDYxNjQyMjAtNTdiOS00NGYwLWFmNTAtNThmYjU5ZGI2YTI1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SY1000_CR0,0,675,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 3, PictureName = "https://m.media-amazon.com/images/M/MV5BMDg2YzI0ODctYjliMy00NTU0LTkxODYtYTNkNjQwMzVmOTcxXkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_SY1000_CR0,0,648,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 4, PictureName = "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,665,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 5, PictureName = "https://m.media-amazon.com/images/M/MV5BMzA0YWMwMTUtMTVhNC00NjRkLWE2ZTgtOWEzNjJhYzNiMTlkXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SY1000_CR0,0,668,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 6, PictureName = "https://m.media-amazon.com/images/M/MV5BMTY0NDY3MDMxN15BMl5BanBnXkFtZTcwOTM5NzMzOQ@@._V1_SY1000_CR0,0,642,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 7, PictureName = "https://m.media-amazon.com/images/M/MV5BMmRhMmI3ZWItMDRlNC00NWIwLWI1MzItMGYzNjMyMGFiOTA3XkEyXkFqcGdeQXVyNjg3MDMxNzU@._V1_SY1000_CR0,0,712,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 8, PictureName = "https://m.media-amazon.com/images/M/MV5BOTg4ZTNkZmUtMzNlZi00YmFjLTk1MmUtNWQwNTM0YjcyNTNkXkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_SY1000_CR0,0,674,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 9, PictureName = "https://m.media-amazon.com/images/M/MV5BYzdkNGJhNzQtMjY1OC00MDI3LTk0ZDUtNzU0MGZiY2YwZGUxXkEyXkFqcGdeQXVyNzMxNjQxMTk@._V1_.jpg" });
            pictures.Add(new Picture { PictureId = 10, PictureName = "https://m.media-amazon.com/images/M/MV5BMTc1NjIzODAxMF5BMl5BanBnXkFtZTgwMTgzNzk1NzM@._V1_SY1000_CR0,0,631,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 11, PictureName = "https://m.media-amazon.com/images/M/MV5BOTIzYmUyMmEtMWQzNC00YzExLTk3MzYtZTUzYjMyMmRiYzIwXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SY1000_CR0,0,685,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 12, PictureName = "https://m.media-amazon.com/images/M/MV5BOGI4NGRlNjEtZDUwOC00ZmRkLWI1ZTgtOGZmMTk3MzQ0ODVhXkEyXkFqcGdeQXVyNDExMzMxNjE@._V1_SY1000_CR0,0,673,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 13, PictureName = "https://m.media-amazon.com/images/M/MV5BMmEzNTkxYjQtZTc0MC00YTVjLTg5ZTEtZWMwOWVlYzY0NWIwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,666,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 14, PictureName = "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_SY1000_CR0,0,674,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 15, PictureName = "https://m.media-amazon.com/images/M/MV5BMjE4NTA1NzExN15BMl5BanBnXkFtZTYwNjc3MjM3._V1_.jpg" });
            pictures.Add(new Picture { PictureId = 16, PictureName = "https://m.media-amazon.com/images/M/MV5BMjIwMjE1Nzc4NV5BMl5BanBnXkFtZTgwNDg4OTA1NzM@._V1_SY1000_CR0,0,674,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 17, PictureName = "https://m.media-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_SY1000_CR0,0,658,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 18, PictureName = "https://m.media-amazon.com/images/M/MV5BMTYzMDM4NzkxOV5BMl5BanBnXkFtZTgwNzM1Mzg2NzM@._V1_SY1000_CR0,0,674,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 19, PictureName = "https://m.media-amazon.com/images/M/MV5BMTA2NDc3Njg5NDVeQTJeQWpwZ15BbWU4MDc1NDcxNTUz._V1_SY1000_CR0,0,674,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 20, PictureName = "https://m.media-amazon.com/images/M/MV5BOTk5ODg0OTU5M15BMl5BanBnXkFtZTgwMDQ3MDY3NjM@._V1_SY1000_CR0,0,674,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 21, PictureName = "https://m.media-amazon.com/images/M/MV5BMjE2NDkxNTY2M15BMl5BanBnXkFtZTgwMDc2NzE0MTI@._V1_SY1000_CR0,0,648,1000_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 22, PictureName = "https://m.media-amazon.com/images/M/MV5BMzE2MzEzNDc5M15BMl5BanBnXkFtZTcwMzYxOTA3MQ@@._V1_.jpg" });
            pictures.Add(new Picture { PictureId = 23, PictureName = "https://m.media-amazon.com/images/M/MV5BMjUwMjczMzY5OV5BMl5BanBnXkFtZTgwMjgyMTczNTM@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 24, PictureName = "https://m.media-amazon.com/images/M/MV5BMTY1NDIwMjQ1OF5BMl5BanBnXkFtZTgwMzUzMjI4MTI@._V1_UY268_CR4,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 25, PictureName = "https://m.media-amazon.com/images/M/MV5BMTU2NjA1ODgzMF5BMl5BanBnXkFtZTgwMTM2MTI4MjE@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 26, PictureName = "https://m.media-amazon.com/images/M/MV5BMTY1ODI5NzQ1NF5BMl5BanBnXkFtZTgwMzQ5NDM5NTM@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 27, PictureName = "https://m.media-amazon.com/images/M/MV5BMTYxMzM4NDY5N15BMl5BanBnXkFtZTgwNzg1NTI3MzE@._V1_UY268_CR4,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 28, PictureName = "https://m.media-amazon.com/images/M/MV5BMTA1MTUxNDY4NzReQTJeQWpwZ15BbWU2MDE3ODAxNw@@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 29, PictureName = "https://m.media-amazon.com/images/M/MV5BMTM4NDQ3NDQ3Nl5BMl5BanBnXkFtZTcwMjE4NjY0MQ@@._V1_UY268_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 30, PictureName = "https://m.media-amazon.com/images/M/MV5BMjIzNTg4ODM3OV5BMl5BanBnXkFtZTgwMTk0MjkxMzE@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 31, PictureName = "https://m.media-amazon.com/images/M/MV5BMTc1NTQyNDk2NV5BMl5BanBnXkFtZTcwOTE2OTQzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 32, PictureName = "https://m.media-amazon.com/images/M/MV5BMzA0NTcxODEyN15BMl5BanBnXkFtZTcwOTA4MjI0MQ@@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 33, PictureName = "https://m.media-amazon.com/images/M/MV5BZDg1NWMyMGUtZTYwMS00MTM2LWJjYmEtMjVjMWQ1YWE4ODc3XkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 34, PictureName = "https://m.media-amazon.com/images/M/MV5BMjQ1MzcxNjg4N15BMl5BanBnXkFtZTgwNzgwMjY4MzI@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 35, PictureName = "https://m.media-amazon.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 36, PictureName = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 37, PictureName = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 38, PictureName = "https://m.media-amazon.com/images/M/MV5BYzE5MjY1ZDgtMTkyNC00MTMyLThhMjAtZGI5OTE1NzFlZGJjXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg" });
            pictures.Add(item: new Picture { PictureId = 39, PictureName = "https://m.media-amazon.com/images/M/MV5BNjk1Njk3YjctMmMyYS00Y2I4LThhMzktN2U0MTMyZTFlYWQ5XkEyXkFqcGdeQXVyODM2ODEzMDA@._V1_UY268_CR43,0,182,268_AL_.jpg" });
            pictures.Add(new Picture { PictureId = 40, PictureName = "https://m.media-amazon.com/images/M/MV5BMTg0ODc4Mzk2OF5BMl5BanBnXkFtZTgwNDk2MDkyODE@._V1_UX182_CR0,0,182,268_AL_.jpg" });

            context.Picture.AddRange(pictures);
            List<Book> movies = new List<Book>();
            Book m1 = new Book {PictureId = 1, BookId = 2,BookUrl="https://cdn.flipsnack.com/widget/v2/widget.html?hash=ftk8wnkx2",Number_Of_Pages=10, BookName = "Ali Baba", WriterName = "BLA", YearOfPublish = 2018, Summary = "Ali Baba revolves around an opportunistic person seeking to achieve his interests even at the expense of others, including those who are closest to his heart." };
            movies.Add(m1);
            Book m2 = new Book { PictureId = 2, BookId = 3, BookUrl = "https://cdn.flipsnack.com/widget/v2/widget.html?hash=ftk8wnkx2", Number_Of_Pages = 10, BookName = "Ali Baba", WriterName = "BLA", YearOfPublish = 2018, Summary = "Ali Baba revolves around an opportunistic person seeking to achieve his interests even at the expense of others, including those who are closest to his heart." };
            movies.Add(m2);
            context.Book.AddRange(movies);

            SaveChanges(context);
        }
        private void SaveChanges(DbContext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                ); // Add the original exception as the innerException
            }
        }
    }

}
