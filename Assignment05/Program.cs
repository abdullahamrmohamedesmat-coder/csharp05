namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //1st answer
            Book book = new Book();

            //Console.WriteLine(book.password;);  it don't allow to print it because access modifer for password is private 
            #endregion

            #region question 2
            //2st answer
            Console.WriteLine(book.copiesInStock); // internal, and in the same project 
            #endregion

            #region question 3
            //3st answer
            Console.WriteLine(book.title);
            #endregion

            #region Question 4
            //4st answer
            book.genre = Genre.Science;
            Console.WriteLine(book.genre);
            #endregion

            #region Question 5
            //5st answer
            int sci;
            int fic;
            int non;
            Genre genreScience = Genre.Science;
            Genre genreFinction = Genre.Fiction;
            Genre genreNonficton = Genre.NonFiction;
            sci = (int)genreScience;
            fic = (int)genreFinction;
            non = (int)genreNonficton;
            Console.WriteLine(fic);
            Console.WriteLine(non);
            Console.WriteLine(sci);
            #endregion

            #region Question 6
            //6st answer
            int genreNumber = 1000;
            Genre gen = (Genre)genreNumber;
            Console.WriteLine(gen);
            #endregion

            #region Question 7
            //7st answer
            Genre genre = Genre.Fiction;
            Console.WriteLine(genre.ToString());
            #endregion


            #region Question 8
            //8st answer
            string genreText = "Science";
            Genre genre1;
            genre1 = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(genre1);

            #endregion
        }
    }
}
