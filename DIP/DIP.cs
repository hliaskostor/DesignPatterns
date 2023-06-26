using System;


public abstract class DatabaseConnector
{
    public abstract void Connect();
}


public class Database : DatabaseConnector
{
    public override void Connect()
    {
        Console.WriteLine("Connecting to MySQL database");
    }
}

public class DataManager
{
    private DatabaseConnector connector;

    public DataManager(DatabaseConnector connector)
    {
        this.connector = connector;
    }

    public void LoadData()
    {
        connector.Connect();
        Console.WriteLine("Loading data from the database");
      
    }
}


class DIP
{
    static void Main(string[] args)
    {
       Database Connector = new Database();
        DataManager dataManager = new DataManager(Connector);
        dataManager.LoadData();
    }
}
