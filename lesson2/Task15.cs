//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
public class Task15 {

    public void execute() {

        long day = MainClassLesson2.readArgFromConsole("Введите целое положительное число от 1 до 7");
        
        if( day < 1 || day > 7 ) {
            Console.WriteLine("Число меньше одного или больше 7.");
            Environment.Exit(1);
        }

        if (day == 6 || day == 7) {
            Console.WriteLine(getMessage(day, "выходной"));
        } else
            Console.WriteLine(getMessage(day, "рабочий"));
    } 

    private String getMessage(long day, String text) {
        return $"{day} день недели это {text}";
    }
}
