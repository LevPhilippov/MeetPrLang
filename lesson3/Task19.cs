//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
public class Task19 {

    public void execute() {
       long number =  MainClassLesson3.readArgFromConsole("Вееди 5-значное целое положительное число");
        isFiveDigitNumber(number);
        long lastDigit = number%10;
        long forthtDigit = (number%100-lastDigit)/10;
        long firstDigit = number/10000;
        long secondDigit = (number/1000)%10;

        if(firstDigit == lastDigit && secondDigit == forthtDigit)
            Console.WriteLine($"Number {number} is a palindrome.");
        else
            Console.WriteLine($"Number {number} is NOT a palindrome.");
    }

    private void isFiveDigitNumber(long value) {
        if (value < 10000 || value > 99999) {
            Console.WriteLine("Введенное число не является пятизначным");
            Environment.Exit(1);
        }

}

}