

using LogicalProblems;
Console.WriteLine("1.Fibonacee series\n"+
                   "2.Perfect Number");
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
    default:
        Console.WriteLine("Enter correct choice");
        break;
}