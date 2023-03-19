/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

public class Task26 {

    public Task26() {

    }

    public void execute() {
        long A = getNumberFromConsole("Введите целое неотрицательное число. У отрицательных чисел знак будет проигнорирован.");
        A = Math.Abs(A);
        var signsInNumber = 1;
       //определяем количество символов в числе 
        while(true){
            var x = A % Math.Pow(10,signsInNumber);
            Console.WriteLine($"Проверяем степень {signsInNumber} - остаток от деления равен  {x}");
           if (x == A) {
            break;
           }
            signsInNumber++;;
        }
        Console.WriteLine($"Количество символов в числе {A} - {signsInNumber}");

        //парсим число по количеству символов
        long result = 0;

        for(var i = 0; i < signsInNumber; i++){
            long x = Convert.ToInt64(A%Convert.ToInt64(Math.Pow(10,i+1)));
            long y = Convert.ToInt64(x/Convert.ToInt64(Math.Pow(10,i)));
            result += y;
        }

        Console.WriteLine("Результат: " + result);
    }

    private long getNumberFromConsole(String message){
        long number;
         while (true) {
            Console.WriteLine(message);
            if(long.TryParse(Console.ReadLine() ?? "", out number)){
                break;
            }
        }
        return number;
    } 
}