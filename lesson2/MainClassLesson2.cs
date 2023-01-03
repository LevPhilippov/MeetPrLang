public class MainClassLesson2 {

    public static void Main() {
        new Task10().execute();
        new Task13().execute();
        new Task15().execute();
    }

       public static long readArgFromConsole(String message) {
        long variable;
        Console.WriteLine(message);
        while(true) {
            if (long.TryParse(Console.ReadLine() ?? "0", out variable))
                break;
            Console.WriteLine(message);
        }
        return variable;
   }


}