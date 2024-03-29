using FactoryCustomer;
using MiddleLayer;
using System.Runtime.CompilerServices;

public class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Please choose a customer type, lead or customer: Press 1 for lead and 2 for customer");
        int customerType = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Bill Amount: ");
        decimal billAmount = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter Name: ");
        var customerName = Console.ReadLine();
        Console.Write("Enter Bill Date: ");
        DateTime billDate = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Enter phone number: ");
        var phoneNumber = Console.ReadLine();
        Console.Write("Enter address: ");
        var address = Console.ReadLine();

        CustomerBase? cust = null;
        cust = Factory.Create(customerType);

        cust.CustomerName = customerName;
        cust.BillAmount = billAmount;
        cust.PhoneNumber = phoneNumber;
        cust.BillDate = billDate;
        cust.Address =address;

        cust.Validate();
    }
}