public class Task4 {
    //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    public void execute() {
          long number = MainClass.readArgFromConsole("Введи целое число и супер-программа выведет четные числа от 1 до твоего числа");
            if(number==0) {
                Console.WriteLine("Введенное число являетcя нулем.");
            }
            long absNumber = Math.Abs(number);
            List<long> list = new List<long>();
            bool positive = number >= 0 ? true : false; 
            for(long i = 0; i<=absNumber; i+=2) {
                if(!positive && i != 0) {
                    list.Add(-i);
                    continue;
                }
                list.Add(i);
            }
            Console.WriteLine(String.Join(", ", list));
    }

}