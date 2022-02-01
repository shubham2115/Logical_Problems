

using LogicalProblems;
Console.WriteLine("1.Fibonacee series\n"+
                   "2.Perfect Number\n"+
                   "3.Prime Number\n"+
                   "4.Coupan number");
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
    case 4:
        coupanNumber coupanNum = new coupanNumber();
        coupanNum.coupan();
        break;
        
    default:
        Console.WriteLine("Enter correct choice");
        break;
}