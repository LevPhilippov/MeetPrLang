//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
public class Task13 {
    public long execute() {
        long number = MainClassLesson2.readArgFromConsole("Введите трехзначное положительное число");
        if (number < 0) {
            Console.WriteLine("Число отрицательное.");
            Environment.Exit(1);
        }
        if (number >= 1000 || number < 100) {
            Console.WriteLine("Число не является трехзначным.");
            Environment.Exit(1);
        }
        return number;
    }
}