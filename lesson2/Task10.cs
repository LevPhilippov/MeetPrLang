//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
public class Task10 {
    public void execute() {
        long userNumber = Task13.checkNumberQuantity(MainClassLesson2.readArgFromConsole("Введите трехзначное положительное число"));
        long number = userNumber % 100;

        if (number < 10)
            Console.WriteLine($"Вторая цифра числа {userNumber} - 0");
        else
            Console.WriteLine($"Вторая цифра числа {userNumber} - {number.ToString().Substring(0,1)}");
        
    }
}