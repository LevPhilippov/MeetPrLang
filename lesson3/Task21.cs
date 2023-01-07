//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
public class Task21 {

    public void execute(){
            long[] firstCoordinate = getCoordinatesList("Введите через запятую координаты первой точки (целые числа).");
            printMessageAfterEnterACoondinate(firstCoordinate);
            long[] secondCoordinate = getCoordinatesList("Введите через запятую координаты второй точки (целые числа).");
            printMessageAfterEnterACoondinate(secondCoordinate);
            double range = Math.Sqrt(
                Math.Pow(Convert.ToDouble(firstCoordinate[0]-secondCoordinate[0]), 2.0) +
                Math.Pow(Convert.ToDouble(firstCoordinate[1]-secondCoordinate[1]), 2.0) +
                Math.Pow(Convert.ToDouble(firstCoordinate[2]-secondCoordinate[2]), 2.0)
                );
            Console.WriteLine($"Растояние между точками равно {range}");
    }

    private long[] getCoordinatesList(String message){
        long[] coordinates = new long[3];
        while(true) {
            Console.WriteLine(message);
            String userCoordinates = Console.ReadLine() ?? "";
            String[]? tokens = userCoordinates.Split(",");
            if(tokens == null || tokens.Length != 3){
                Console.WriteLine("Введены неверные данные. Точек координат больше 3-х.");
                continue;
            }
            bool isCoordinatesEnteredCorrect = true;
            for(int i = 0; i<coordinates.Length; i++){
                isCoordinatesEnteredCorrect &=long.TryParse(tokens[i].Trim(), out coordinates[i]);
            }
            if (isCoordinatesEnteredCorrect)
                break;
            else
                Console.WriteLine("Что-то пошло не так. Попробуем снова.");
        }
        return coordinates;
    }

    private void printMessageAfterEnterACoondinate(long[] coordinate) {
        Console.WriteLine($"Введена следующая координата: x={coordinate[0]}, y={coordinate[1]}, z={coordinate[2]}");
    }
}