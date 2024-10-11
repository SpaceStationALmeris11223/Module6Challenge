public class Book // declares public class named book
{// Down below are auto implemented properties, (title, author, etc)
    public string Title {get; set;}
    public string Author {get; set;}//get & set allows these props to be 
    public string ISBN {get; set;}//written and read
    public Book(string title, string author, string isbn)
    {//This constructore takes 3 params and intialzed the corresponding propeties of the book obj
        Title = title;
        Author = author;
        ISBN = isbn;
    }
    public override string ToString()
    {//Overrides the default ToString method. So that the string below is returned
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}