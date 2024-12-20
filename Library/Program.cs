namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            Book bookOne = new Book("Behave", "Rober Sapolsky", 2015); 
            Book bookTwo = new Book("Ion", "Liviu Rebreanu", 2000);

            Magazine magazineOne = new Magazine("Nature", "Albert Einstein", 1922);
            Magazine magazineTwo = new Magazine("Time", "Mark Thompson", 2017);

            DVD dvdOne = new DVD("Matrix", "Lana Wachowski", 1999);
            DVD dvdTwo = new DVD("Fight Club", "David Fincher", 1999);

            myLibrary.AddItem(bookOne);
            myLibrary.AddItem(bookTwo);
            myLibrary.AddItem(magazineTwo);
            myLibrary.AddItem(magazineOne);
            myLibrary.AddItem(dvdOne);
            myLibrary.AddItem(dvdTwo);

            myLibrary.DisplayLibrary();

            myLibrary.BorrowItem("Behave");
            myLibrary.BorrowItem("Time");
            myLibrary.BorrowItem("Fight Club");

            myLibrary.ReturnItem("Time");
            myLibrary.DisplayLibrary();

        }
    }
}
