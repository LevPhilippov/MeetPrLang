/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/
public class Task29 {

    public void execute() {
        string initialString = "1,2 34, 56, 32, 54, 21, 5232141";
        string[] stringArray = initialString.Split(',');
        for(int i = 0; i < stringArray.Length; i++) {
            Console.Write($"{stringArray[i].Trim()} ");
        }

    }
}