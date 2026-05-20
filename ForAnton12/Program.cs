class Book
{
  public string? title;
  public int year;
  public bool isTaken;
}

class Program
{
    static void Main()
    {
        Book[] books = new Book[5];

        books[0] = new Book {title = "Harry Potter and the Philosopher's Stone", year = 1997, isTaken = false};
        books[1] = new Book {title = "Harry Potter and the Chamber of Secrets", year = 1998, isTaken = false};
        books[2] = new Book {title = "Harry Potter and the Prisoner of Azkaban", year = 1999, isTaken = false};
        books[3] = new Book {title = "Harry Potter and the Goblet of Fire", year = 2000, isTaken = false};
        books[4] = new Book {title = "Harry Potter and the Order of the Phoenix", year = 2003, isTaken = false};

        
          ShowBooks(books);
          Console.WriteLine("---------------------------");
          TakeBook(books, "Harry Potter and the Philosopher's Stone");
          TakeBook(books, "Harry Potter and the Chamber of Secrets");
          TakeBook(books, "Harry Potter and the Prisoner of Azkaban");
          TakeBook(books, "Harry Potter and the Goblet of Fire");
          TakeBook(books, "Harry Potter and the Order of the Phoenix");
          ShowBooks(books);
          Console.WriteLine("---------------------------");
          ReturnBook(books, "Harry Potter and the Philosopher's Stone");
          ReturnBook(books, "Harry Potter and the Chamber of Secrets");
          ReturnBook(books, "Harry Potter and the Prisoner of Azkaban");
          ReturnBook(books, "Harry Potter and the Goblet of Fire");
          ReturnBook(books, "Harry Potter and the Order of the Phoenix");
          ShowBooks(books);
    }

    static void ShowBooks(Book[] books)
    {
      for(int i = 0; i<books.Length; i++)
        {
          Console.WriteLine(books[i].title);
          Console.WriteLine(books[i].year);
          if(books[i].isTaken==false)
           {
                Console.WriteLine("Книга НЕ взята");
           }
            
          else
            {
                Console.WriteLine("Книга ВЗЯТА");
            }
        }
    }

    static void TakeBook(Book[] books, string bookTitle)
        {
            for(int i = 0; i < books.Length; i++)
            {
                if(books[i].title == bookTitle)
                {
                    books[i].isTaken = true;
                }
                
            }
        }

    static void ReturnBook(Book[] books, string bookTitle)
        {

            for(int i = 0; i < books.Length; i++)
            {
                if(books[i].title == bookTitle)
                {
                    books[i].isTaken = false;
                    
                }
                
            }

        }






    }   
