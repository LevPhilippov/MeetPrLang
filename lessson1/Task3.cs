public class Task3 {
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

    public void execute () {
          long number = MainClass.readArgFromConsole("Введите целое число и супер-программа определит, четное ли оно.");
          Console.WriteLine(number%2 == 1 ? $"Число {number} нечетное." : $"Число {number} четное.");
    }

}
