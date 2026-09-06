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
        }
    }
}
