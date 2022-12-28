decimal loanAmount = 0;
decimal loanAmountCopy = 0;

Console.WriteLine("Please enter a loan amount");

loanAmount = Convert.ToDecimal(Console.ReadLine()); //100
loanAmountCopy = Convert.ToDecimal(Console.ReadLine()); //50

loanAmountCopy = loanAmount; //100

Console.WriteLine($"loanAmount : {loanAmount} loanAmount Copy: {loanAmountCopy}");
Console.ReadKey();
loanAmount = loanAmount + 600;
Console.WriteLine();
Console.WriteLine($"After adding 600 pounds loanAmount: {loanAmount} , and loanAmountCopy: {loanAmountCopy}");