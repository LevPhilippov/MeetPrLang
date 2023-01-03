public class MainClass {
   private static String errorMessage = "You entered wrong argument!";

    public static void Main() {
    Console.WriteLine("Какую таску запустить?");
    int taskNum = int.Parse(Console.ReadLine() ?? "1");

    switch(taskNum) {
        case 1 :
            //First task
            new Task1().execute();
            break;
        case 2 :
            //Second task
            new Task2().execute();
            break;
        case 3 :
            //Third task
            new Task3().execute();
            break;
        case 4 :
            //Forth task
            new Task4().execute();
            break;
        default:
            Console.WriteLine("Неверный выбор"); 
            break;

    }    
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

