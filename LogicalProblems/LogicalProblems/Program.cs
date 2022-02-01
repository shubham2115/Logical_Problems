

using LogicalProblems;
Console.WriteLine("1.Fibonacee series\n"+
                   "2.Perfect Number\n"+
                   "3.Prime Number");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        FIbonacee fibonacee = new FIbonacee();
        fibonacee.Series();
        break;
    case 2:
        Perfect perfect = new Perfect();
        perfect.perfectNumber();
        break;
    case 3:
        prime prime = new prime();
        prime.primeNumber();
        break;
    default:
        Console.WriteLine("Enter correct choice");
        break;
}