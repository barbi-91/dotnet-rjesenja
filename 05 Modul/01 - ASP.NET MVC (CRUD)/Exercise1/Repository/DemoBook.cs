using Exercise1.Models;

namespace Exercise1.Repository
{
    public class DemoBook
    {
        //field -kolekcija podataka
        private static List<Book> _books;

        //Ctor - ako je lista prazna napuni je pozivom metode koja sadzi punu listu
        public DemoBook()
        {
            if (_books == null)
            {
                _books = new List<Book>();
                DemoBookData();
            }  
        }

        //pomocna metoda sa testnim podacima
        private void DemoBookData()
        {
            _books = new List<Book>();
            _books.Add(new Book { Id = 1, Author = "Antoine de Saint-Exupéry", Genere = "Basna", PublicationDate = 1943 - 04 - 06, Title = "Mali princ" });
            _books.Add(new Book { Id = 2, Author = "Ernest Hemingway", Genere = "Roman", PublicationDate = 1952 - 11 - 23, Title = "Starac i more" });
            _books.Add(new Book { Id = 3, Author = "Mark Twain", Genere = "Roman", PublicationDate = 1876 - 05 - 30, Title = "Pustolovine Toma Sawyera" });
            _books.Add(new Book { Id = 4, Author = "Mato Lovrak", Genere = "Roman", PublicationDate = 1976 - 06 - 10, Title = "Vlak u snijegu" });

        }


        // 1 Metoida za ispis
        public List<Book> GetBooks()
        {
            return _books;
        }

        // 2 Metoda za kreiranje nove knjige
        public void CreateBook(Book book)
        {
            _books.Add(book);
        }

        // 3 Metoda za dohvat po Idu-u
        public Book GetById(int id)
        {
            return _books.FirstOrDefault(a => a.Id == id);
        }

        // 4 Metoda za editiranje ili update postojeceg podataka
        public void UpdateData (int id, Book book)
        {
            var idBook = _books.FirstOrDefault(b => b.Id == id);

            if (idBook != null)
            {
                idBook.Title = book.Title;
                idBook.Author = book.Author;
                idBook.PublicationDate = book.PublicationDate;
            }

        }

        // Metoda za delitanje objekta iz liste
        public void DeleteBook(Book deleteBookBYID)
        {
            var book = _books.FirstOrDefault(b => b.Id == deleteBookBYID.Id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }
    }
}
