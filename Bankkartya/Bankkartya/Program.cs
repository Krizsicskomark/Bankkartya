using System;
using System.ComponentModel.Design;

public class Bankkartya
{
    public string OwnerName { get; set; }
    public string CardNumber { get; set; }
    public DateTime ExpirationDate { get; set; }
    public decimal Balance { get; set; }

    public Bankkartya(string ownerName, string cardNumber, DateTime expirationDate, decimal balance)
    {
        OwnerName = ownerName;
        CardNumber = cardNumber;
        ExpirationDate = expirationDate;
        Balance = balance;
    }

    public void PenzKivetel(decimal amount)
    {   if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{amount} FT sikeresen felvéve. Új egyenleg:{Balance} FT");
        }
        else
        {
            Console.WriteLine("Nem megfelelő összeg vagy nincs elegendő egyenleg a számlán");
        }
    }
    public void PrintCardInfo()
    {
        Console.WriteLine("Bankkártya adatai:");
        Console.WriteLine($"Tulajdonos neve: {OwnerName}");
        Console.WriteLine($"Kártyaszám: {CardNumber}");
        Console.WriteLine($"Lejárati dátum: {ExpirationDate:yyyy-MM-dd}");
        Console.WriteLine($"Egyenleg: {Balance} Ft");
    }

}

