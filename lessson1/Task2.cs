public class Task2
{
   private static int agrsNumber = 3;
 
   public void execute() {
      //  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        List<long> list = new List<long>();

        for (int i =0; i<agrsNumber; i++) {
            list.Add(MainClass.readArgFromConsole(getEnterMessage(i)));
        }
        list.Sort();
        Console.WriteLine($"Максимальное введенное число {list.Last()}");
   }

   private static String getEnterMessage(int argnum) {
        return $"Enter the {argnum} argument (only whole numbers).";
   }

}
