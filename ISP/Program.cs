using System;

public class Door
{
    public void Lock()
    {
     
    }

    public void Unlock()
    {
     
    }
}

public interface PasswordClient
{
    void Alarm();
    void SetMyProtector(PasswordProtector theProtector);
}

public class ProtectedDoor : Door, PasswordClient
{
    private bool locked;
    private PasswordProtector myProtector;

    public void Lock()
    {
        locked = true;
    }

    public void Unlock()
    {
        Console.Write("Enter code: ");
        int number = Convert.ToInt32(Console.ReadLine());
        myProtector.Check(number);
    }

    public void Alarm()
    {
        Console.WriteLine("ALARM: Someone is trying to enter without a code!!");
    }

    public void SetMyProtector(PasswordProtector theProtector)
    {
        myProtector = theProtector;
    }
}

public class PasswordProtector
{
    private int safeNumber;
    private PasswordClient myClient;
    private int number;

    public void Register(int code, PasswordClient client)
    {
        safeNumber = code;
        myClient = client;
        client.SetMyProtector(this);
    }

    public void Check(int code)
    {
        if (code != safeNumber)
        {
            myClient.Alarm();
        }
        else if (code != number)
        {
            number = code;
            Console.WriteLine("The code is correct: " + code);
        }
    }
}

public class ISP
{
    public static void Main(string[] args)
    {
        PasswordProtector protector = new PasswordProtector();
        ProtectedDoor door = new ProtectedDoor();
        protector.Register(2525, door);
        door.Unlock();
    }
}
