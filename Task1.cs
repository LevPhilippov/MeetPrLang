
public class Task1 {

public void execute() {
      //  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        long firstArg;
        long secondArg;
        firstArg = MainClass.readArgFromConsole("Enter the first argument (only whole numbers).");
        secondArg = MainClass.readArgFromConsole("Enter the second argument (only whole numbers).");
        if(firstArg > secondArg) {
            Console.WriteLine($"{firstArg} is bigger than {secondArg}");
            return;
        } else if (firstArg<secondArg) {
            Console.WriteLine($"{secondArg} is bigger than {firstArg}");
            return;
        }
            Console.WriteLine($"{secondArg} is equal to {firstArg}");

   }

}