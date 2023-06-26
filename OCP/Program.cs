using System;

public abstract class Restaurant
{
    public abstract void RestaurantPayment(int bill);
}

public class CreditCardPayment : Restaurant
{
    public override void RestaurantPayment(int bill)
    {
        Console.WriteLine("Table 1 is paid " + bill + "euros");
    }
}

public class CashPayment : Restaurant
{
    public override void RestaurantPayment(int bill)
    {
        Console.WriteLine($"Table 2 is paid" + bill + "euros");
    }
}

public class PaymentOptions
{
    private Restaurant payment;

    public PaymentOptions(Restaurant pay)
    {
        payment = pay;
    }

    public void Pay(int bill)
    {
        payment.RestaurantPayment(bill);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CreditCardPayment creditCard = new CreditCardPayment();
        CashPayment cash = new CashPayment();

        PaymentOptions table1 = new PaymentOptions(creditCard);
        table1.Pay(20);

        PaymentOptions table2 = new PaymentOptions(cash);
        table2.Pay(40);


    }
}
