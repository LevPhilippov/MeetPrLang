//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter the first argument (only whole numbers).");
long firstArg;
long secondArg;
String message = "You entered wrong argument!";
try{
    firstArg =  long.Parse(Console.ReadLine() ?? "0");
} catch (Exception e) {
    Console.WriteLine();
    throw e;
}
Console.WriteLine(message);
try{
    secondArg =  long.Parse(Console.ReadLine() ?? "0");
} catch (Exception e) {
    Console.WriteLine(message);
    throw e;
}

if(firstArg> secondArg) {
    Console.WriteLine($"{firstArg} is bigger than {secondArg}");
    return;
} 
Console.WriteLine($"{secondArg} is bigger than {firstArg}");

