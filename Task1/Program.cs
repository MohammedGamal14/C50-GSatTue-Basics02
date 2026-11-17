namespace Task1
{
   class Book
    {
        public string Title;
        public int Pages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Create a Book class with a Title (string) and Pages (int).
            // Create a Book object and store it in a variable of type object. Print it.
            Book book = new Book();
            book.Title = "C# Book";
            book.Pages = 464;
            object obj = book;
            Console.WriteLine(obj);
            #endregion

            #region Q2
            // Print the result of calling ToString(), Equals() (compare book with itself),
            // GetHashCode(), and GetType() on book.
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            #endregion

            #region Q3
            // int pages = "464"; Is it a compile-time error, a runtime error, or a logical error? Fix it.
            // Answer: Compile-time error
            int pages = 464;
            #endregion

            #region Q4
            // Divide 10 by 0 inside a try block, catch the exception,
            // print "Cannot divide by zero", then print "Done" in a finally block.
            try
            {
                int zero = 0;
                int x = 10 / zero;
            }
            catch
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region Q5
            // Declare an int pages = 300; then store it in a double variable without using a cast.
            int pages2 = 300;
            double d = pages2;
            Console.WriteLine(d);
            #endregion

            #region Q6
            // Declare a double price = 49.99; then convert it into an int using a cast.
            double price = 49.99;
            int p = (int)price;
            Console.WriteLine(p);
            #endregion

            #region Q7
            // Given string pagesText = "464";, convert it into an int using the Convert class.
            string pagesText = "464";
            int n = Convert.ToInt32(pagesText);
            Console.WriteLine(n);
            #endregion

            #region Q8
            // Given string yearText = "2023";, convert it using int.Parse().
            // Then given string badText = "abc";, use int.TryParse() to safely try converting it,
            // and print "Invalid number" if it fails.
            string yearText = "2023";
            int y = int.Parse(yearText);
            Console.WriteLine(y);

            string badText = "abc";
            int r;
            if (!int.TryParse(badText, out r))
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

        }
    }
}
