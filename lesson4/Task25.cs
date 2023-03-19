
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
public class Task25 {

    public Task25() {

    }

    public void execute() {
        long A = getNumberFromConsole("Введите целое число, которое требуется возвести в степень.");
        long B  = getNumberFromConsole("Введите cтепень, в которую необходимо возвести число.");
        var result = Math.Pow(A,B);
        Console.WriteLine($"Результат вычисления {result}");
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