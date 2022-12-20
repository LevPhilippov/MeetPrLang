public class MainClass {
   private static String errorMessage = "You entered wrong argument!";

    public static void Main() {
    //First task
    new Task1().execute();
    //Second task
    new Task2().execute();
   }

   public static long readArgFromConsole(String message) {
    Console.WriteLine(message);
        try{
            return long.Parse(Console.ReadLine() ?? "0");
        } catch (Exception e) {
            Console.WriteLine(errorMessage);
            throw e;
        }
   }

}

