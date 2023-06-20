using System;

public class Book
{
    private string title;
    private string author;
    private string content;

    public Book(string title, string author, string content)
    {
        this.title = title;
        this.author = author;
        this.content = content;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public string GetContent()
    {
        return content;
    }
}

public class BookPrinter
{
    public void PrintBook(Book book)
    {
        Console.WriteLine($"Title: {book.GetTitle()}");
        Console.WriteLine($"Author: {book.GetAuthor()}");
        Console.WriteLine("Content:");
        Console.WriteLine(book.GetContent());
    }
}

class SRP
{
    static void Main(string[] args)
    {
        Book book = new Book("Python Programming", "John Smith", "Learn Python programming...");
        BookPrinter printer = new BookPrinter();
        printer.PrintBook(book);
    }
}
