using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{//This class has 2 properties
    public string Name {get; set;}//Represents the name of the libary
    private List<Book> Books {get; set;}//A private list to store books
    
    public Library(string name)//Takes a name parameter to sets the library name
    {
        Name = name;
        Books = new List<Book>();//initalize book as an empty list
    }
    public void AddBook(Book book)
    {
        Books.Add(book);//takes book obj as a prameter and adds it to the private list
        Console.WriteLine($"Added: {book}");//confirmation message
    }
    public bool RemoveBook(string isbn)//takes an ISBN string as a param
    {//then it searches for the book that matches the ISBN using LINQ firstOrDefault
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
            if (bookToRemove != null)//If found removes book from list and returns true
            {
                Books.Remove(bookToRemove);
                Console.WriteLine($"Removed: {bookToRemove}");
                return true;
            }
            Console.WriteLine("Book not found.");
            return false;//returns false if not found
    }
    public void DisplayAvailableBooks()//Displays the books in the library
    {
        Console.WriteLine("Available Book: ");
        foreach(var book in Books)
        {
            Console.WriteLine(book);
        }
    }
    public Book GetBook(string isbn)
    {//Takes ISBN as a param and retuns the book with the matching param
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}