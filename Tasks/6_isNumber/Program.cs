public class Tester {

    public static void Main(string[] args){
        Console.WriteLine("Please enter text");

        string text = Console.ReadLine();

        Console.WriteLine(isNumber(text));
    }

    public static bool isNumber(string text){
        double n;
        return double.TryParse(text, out n);
    }
}