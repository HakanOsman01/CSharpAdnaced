
using System.Collections;

namespace Iterator_and_Comparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books=new List<Book>();
        public Library(params Book[]books)
        {
            this.books=books.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
           books.Sort();
           return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        class LibraryIterator:IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex=-1;
            public LibraryIterator(List<Book>books)
            {
                this.books = books;
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
              currentIndex++;
              return currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
