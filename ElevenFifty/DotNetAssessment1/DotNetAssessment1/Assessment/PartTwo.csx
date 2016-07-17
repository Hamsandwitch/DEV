using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;



//Part Two
public enum Gender
{

    Unknown,
    Male,
    Female,

};

public class Customer
{
    private string _name;
    private string _purchase;
    private string _gender;
    private int _date;
    private string _info;


    public Customer(string name, string purchase, Gender gender)  //2 Constructor
    {

        Name = name;
        Purchase = purchase;
        Gender = gender;

    }

    public string Name
    {
    get { return _name; }
    set { _name = value.Trim(); }
    }
    public string Gender
    {
    get { return _gender; }
    set { _gender = value.Trim(); }
    }
    public string Purchase
    {
    get { return _purchase; }
    set { _purchase = value.Trim(); }
    }
    public string Info
    {
        get { return _info; }
        set { _info = value.Trim(); }
    }
    public string Date
    {
        get { return _date; }
        set { _date = value.Trim(); }
    }
    public override string ToString() // 3
    {
    return $"Hello {Name}, thank you for purchasing {Purchase}. We hope you enjoy it!";
    }
    public virtual string printCustomerInfo() // 9
    {
        Console.WriteLine($"{Name} - {Purchase} - {Gender}");
    }
    var date = DateTime.Now;
    public class sendSalesNotice // 4
    {

    public string SalesNotice(string date)
    {
        return $"Hello Dave, We wanted to let you know there's a sale coming up on {date}.";
    }
    public string SalesNotice(string date, string saleItem)
    {
        return $"Hello Dave, We wanted to let you know there's a sale on {saleItem} starting {date}.";
    }

}

protected virtual void inactiveCustomer(int monthsInactive) : base Customer;
{ 
    protected enum reasonInactive
    {

    Dead,
    Coma,
    BetterChoices,

    };
    protected override string printCustomerInfo() // 9
    {
    Console.WriteLine($"{Name} - {Purchase} - {Gender} - {reasonInactive}");
    }

    Console.WriteLine($"Thanks for shopping with us {Name}. We saw that you purchased an {Purchase} from us {monthsInactive} months ago. We'd like to know if you'd like to take a look at some of our current deals.");

}










var xx = new sendSalesNotice(date);
var xxx = new sendSalesNotice(date, wordsnstuff);
Console.WriteLine(xx);
Console.WriteLine(xxx);


Console.WriteLine($"Hello Dave, We wanted to let you know there's a sale coming up on {date}.");









