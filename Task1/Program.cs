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
        }
    }
}
