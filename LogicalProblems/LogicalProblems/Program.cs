

using LogicalProblems;
Console.WriteLine("1.Fibonacee series\n"+
                   "2.Perfect Number\n"+
                   "3.Prime Number\n"+
                   "4.Coupan number\n"+
                   "5.Reverse Number\n"+
                   "6.Check day for date\n"+
                   "7.Temprature conversion\n"+
                   "8.Sqrt newtons method"
                   );
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
    case 5:
        ReverseNumber reverseNumber = new ReverseNumber();
        reverseNumber.reverseNmuber();
        break;
    case 6:
        DayForDate dayForDate = new DayForDate();
        dayForDate.checkDayForADate();
        break;
    case 7:
        TempratureConversion tempratureConversion = new TempratureConversion();
        tempratureConversion.temperatureConversion();
        break;
    case 8:
        SqrtNewtonsMethod sqrtNewtonsMethod = new SqrtNewtonsMethod();
        sqrtNewtonsMethod.sqrtNewtonsMethod();
        break;
    
        
    default:
        Console.WriteLine("Enter correct choice");
        break;
}