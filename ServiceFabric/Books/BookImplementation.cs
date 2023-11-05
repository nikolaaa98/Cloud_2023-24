using CommonLibrary;

namespace Books
{
    public class BookImplementation : IBooks
    {
        public bool WriteAllBooks(Book k)
        {
            if (k.Name != "Knjiga")
                return true;
            else
                return false;
        }
    }
}