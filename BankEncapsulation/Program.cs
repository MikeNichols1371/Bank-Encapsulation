using BankEncapsulation;


var bankAccount = new BankAccount();
Console.WriteLine("Welcome to your bank account");
Console.WriteLine();

Console.WriteLine("Would you like to check your account balance?");
var checkBalance = Console.ReadLine();
string str1 = "yes";
string str2 = "Yes";
string str3 ="no";
string str4 = "No";

string deposit2;

if (checkBalance == str1 || checkBalance == str2)
{
    Console.WriteLine($"Your account balance is: ${bankAccount.GetBalance()}");
    Console.WriteLine();
    Console.WriteLine("Would you like to make a deposit");
    string deposit1 = Console.ReadLine();
    if (deposit1 == str1 || deposit1 == str2)
    {
        Console.WriteLine("What amount would you like to deposit");
        var depositAmount = double.Parse(Console.ReadLine());
        bankAccount.Deposit(depositAmount);
        Console.WriteLine($"Your new account balance is: ${bankAccount.GetBalance()}.");
        Console.WriteLine("Thank you have a nice day.");
        Console.WriteLine();
    }
    else if (deposit1 == str3 || deposit1 == str4)
    {
        Console.WriteLine("Would you like to make a withdrawal?");
        var withdrawal1 = Console.ReadLine();
        Console.WriteLine();
        if (withdrawal1 == str1 || withdrawal1 == str2)
        {
            Console.WriteLine("What ammount would you like to withdrawal?");
            var withdrawalAmount = double.Parse(Console.ReadLine());
            bankAccount.Withdrawal(withdrawalAmount);
            bankAccount.GetBalance();
            if (bankAccount.GetBalance() > 0)
            {
                Console.WriteLine("Your new balance is: ");
                Console.WriteLine(bankAccount.GetBalance());
                Console.WriteLine("Thank you have a nice day.");
                Console.WriteLine();
            }
            else if (bankAccount.GetBalance() !> 0)
            {
                Console.WriteLine("You dont have sufficient funds for this transaction.");
                Console.WriteLine("Get ya money up");
                Console.WriteLine();
            }
            
        }
        else if (withdrawal1 == str3 || withdrawal1 == str4)
        {
            Console.WriteLine("Thank you have a nice day.");
            Console.WriteLine();
        }
    }

}
else if (checkBalance == str3 || checkBalance == str4)
{
    Console.WriteLine("Would you like to make a deposit");
    string deposit1 = Console.ReadLine();
    if (deposit1 == str1 || deposit1 == str2)
    {
        Console.WriteLine("What amount would you like to deposit");
        var depositAmount = double.Parse(Console.ReadLine());
        bankAccount.Deposit(depositAmount);
        Console.WriteLine($"Your new account balance is: ${bankAccount.GetBalance()}.");
        Console.WriteLine("Thank you have a nice day.");
        Console.WriteLine();
    }
    else if (deposit1 == str3 || deposit1 == str4)
    {
        Console.WriteLine("Would you like to make a withdrawal?");
        var withdrawal1 = Console.ReadLine();
        Console.WriteLine();
        if (withdrawal1 == str1 || withdrawal1 == str2)
        {
            Console.WriteLine("What ammount would you like to withdrawal?");
            var withdrawalAmount = double.Parse(Console.ReadLine());
            bankAccount.Withdrawal(withdrawalAmount);
            bankAccount.GetBalance();
            if (bankAccount.GetBalance() > 0)
            {
                Console.WriteLine($"Your new balance is: ${bankAccount.GetBalance()}");
                Console.WriteLine("Thank you have a nice day.");
                Console.WriteLine();
            }
            else if (bankAccount.GetBalance() <0 )
            {
                Console.WriteLine("You dont have sufficient funds for this transaction.");
                Console.WriteLine("Get ya money up");
                Console.WriteLine();
            }
            
        }
        else if (withdrawal1 == str3 || checkBalance == str4)
        {
            Console.WriteLine("Thank you have a nice day.");
            Console.WriteLine();
        }
    }
}










