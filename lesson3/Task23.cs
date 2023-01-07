//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
public class Task23 {

    public void execute(){
        long number =  MainClassLesson3.readArgFromConsole("Введите целое положительное число.");
        
        if (number < 0) {
            Console.WriteLine("Число отрицательное.");
            Environment.Exit(1);
        }
        var stringBuilder = new System.Text.StringBuilder();

        for(long i = 0; i< number; i++) {
            stringBuilder.Append(Math.Pow(Convert.ToDouble(i),3.0));
            stringBuilder.Append(", ");
        }
        var result = stringBuilder.ToString().Trim().Substring(0,stringBuilder.Length-2);
        Console.WriteLine(result);
    }



}