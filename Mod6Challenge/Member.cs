using System;
using System.Collections.Generic;
using System.Linq;
//Increases basic system functionality 
public class Member
{//Has 3 properties Name,ID,Borrwedbooks
    public string Name {get; set;}
    public int ID {get; set;}
    private List<Book> BorrowedBooks {get; set;}

    public Member(string name, int id)
    {//Constructors takes name and id as a param
        Name = name;
        ID = id;
        BorrowedBooks = new List<Book>();
    }//creates a empty list for books
    public void BorrowedBook(Library library, string isbn)
    {//Takes a library object and a ISBN(string as a param)
        Book book = library.GetBook(isbn);
        if(book != null)
        {//If the book is available they get added it to member borrowed book list
            BorrowedBooks.Add(book);
            library.RemoveBook(isbn);
            Console.WriteLine($"{Name} borrowed: {book}");
        }
        else
        {//If it doesn't find it, the program informs the user
            Console.WriteLine("Book not available.");
        }
    }
    public void ReturnBook(Library library, string isbn)
    {//Prints memeber name + books borrowed by the memeber
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
        {
            if(book != null)
            {
                BorrowedBooks.Remove(book);
                library.AddBook(book);
                Console.WriteLine($"{Name} returned: {book}");
            }
            else
            {
                Console.WriteLine("Book not found in borrowed list.");
            }
        }
        }
        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"{Name}'s borrowed books:");
            foreach (var book in BorrowedBooks)
            {
            Console.WriteLine(book);
            }
        }
        
    }
