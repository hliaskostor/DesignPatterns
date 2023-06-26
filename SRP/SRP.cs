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

public class BookPrinter : Book
{
    public BookPrinter(string title, string author, string content) : base(title, author, content)
    {
    }

    public void PrintBook()
    {
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine($"Author: {GetAuthor()}");
        Console.WriteLine($"Content:{GetContent()}");
      
    }
}

class SRP
{
    static void Main(string[] args)
    {
        BookPrinter printer = new BookPrinter("C# Programming", "Stan Smith", "Learn C# Design Patterns");
        printer.PrintBook();
    }
}
