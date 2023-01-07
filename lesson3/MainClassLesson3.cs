public class MainClassLesson3 {

    public static void Main(){
        new Task23().execute();
    }

    public static long readArgFromConsole(String message) {
        long variable;
        Console.WriteLine(message);
        while(true) {
            if (long.TryParse(Console.ReadLine() ?? "", out variable))
                break;
            Console.WriteLine(message);
        }
        return variable;
   }
}
