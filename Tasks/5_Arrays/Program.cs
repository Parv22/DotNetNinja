public class Tester {

    public static void Main(string[] args){
        int[] numArray = new int[10];
        for(int i =0; i<10;i++){
            Console.WriteLine("Enter integer");
            numArray[i] = int.Parse(Console.ReadLine());
        }

        for(int i=0; i<10; i++){
            if (numArray[i] % 2 == 0){
                Console.WriteLine(numArray[i]);
            }
        }
    }
}