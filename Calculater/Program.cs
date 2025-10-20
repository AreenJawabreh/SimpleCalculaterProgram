int num1;
int num2;
int result;
string answer;

Console.WriteLine("Hello, Welcome to the caculater program!");
Console.WriteLine("Please enter the first number:");
num1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter you second number:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What type of operation would you like to do?");
Console.WriteLine("Please enter 'a' for addition, 's' for subtraction, 'm' for multiplication or 'd' fro division:");
answer = Console.ReadLine();
switch (answer)
{
    case "a":
        result = num1 + num2;
        break;
    case "s":
        result = num1 - num2;
        break;
    case "m":
        result = num1 * num2;
        break;
    case "d":
        result = num1 / num2;
        break;
    default:
        result = 0;
        break;

        
}
Console.WriteLine("The result is: " + result);
Console.WriteLine("Thank you for using the calculater program!");


Console.ReadKey();  
