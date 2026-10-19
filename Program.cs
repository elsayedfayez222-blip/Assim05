using System;

namespace Assim05
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    } //

    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title { get; set; }
        public Genre BookGenre { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Add a private string password secret field to a Book class Try to print it from Main outside the class What happens and why
            Book myBook = new Book();
            // Console.WriteLine(myBook.password); 
            // Answer: Compile error because private fields are only accessible inside the class itself
            #endregion

            #region Q2
            // Add an internal int copiesInStock 5 field to Book Print it from Main Does it compile Why
            Console.WriteLine(myBook.copiesInStock);
            // Answer: Yes it compiles because internal is accessible anywhere inside the same assembly or project
            #endregion

            #region Q3
            // Add a public string Title field to Book Set it and print it from Main
            myBook.Title = "Clean Code";
            Console.WriteLine(myBook.Title);
            #endregion

            #region Q4
            // Declare an enum Genre Fiction NonFiction Science Add a Genre property to Book assign it Genre Science and print it
            myBook.BookGenre = Genre.Science;
            Console.WriteLine(myBook.BookGenre);
            #endregion

            #region Q5
            // Using the Genre enum above print the underlying int value of Genre Fiction Genre NonFiction and Genre Science by casting each to int
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

            #region Q6
            // Given int genreNumber 1 cast it into a Genre value and print the result
            int genreNumber = 1;
            Genre castedGenre = (Genre)genreNumber;
            Console.WriteLine(castedGenre);
            #endregion

            #region Q7
            // Given Genre genre Genre Fiction convert it into a string using ToString and print it
            Genre genre = Genre.Fiction;
            string genreStr = genre.ToString();
            Console.WriteLine(genreStr);
            #endregion

            #region Q8
            // Given string genreText Science convert it into a Genre value using Enum Parse and print the result
            string genreText1 = "Science";
            Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText1);
            Console.WriteLine(parsedGenre);
            #endregion

            #region Q9
            // Given string genreText Mystery not a valid Genre value use Enum TryParse to attempt the conversion Print Unknown genre if it fails
            string genreText2 = "Mystery";
            bool isParsed = Enum.TryParse(genreText2, out Genre resultGenre);
            if (!isParsed)
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion
        }
    }
}