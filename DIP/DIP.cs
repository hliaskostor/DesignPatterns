using System;

// Abstraction
public abstract class DatabaseConnector
{
    public abstract void Connect();
}

// Concrete Implementation
public class MySQLConnector : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connecting to MySQL database...");
    }
}

// High-level module depending on abstraction
public class DataManager
{
    private DatabaseConnector connector;

    public DataManager(DatabaseConnector connector)
    {
        this.connector = connector;
    }

    public void FetchData()
    {
        connector.Connect();
        Console.WriteLine("Fetching data from the database...");
        // Additional data processing logic
    }
}

// Usage
class DIP
{
    static void Main(string[] args)
    {
        MySQLConnector mysqlConnector = new MySQLConnector();
        DataManager dataManager = new DataManager(mysqlConnector);
        dataManager.FetchData();
    }
}
