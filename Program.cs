namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, skriv in en siffra:");
            int number = int.Parse(Console.ReadLine());

            int EvenOdd = 1;

            for (int row = 0; row < number; row++) 
            {

                for (int column = 0; column < number; column++ ) 
                {
                    if (EvenOdd == 1)
                    {
                        Console.OutputEncoding = System.Text.Encoding.Unicode; 
                        Console.Write("◼︎"); 
                    }
                    else
                    {
                        Console.OutputEncoding = System.Text.Encoding.Unicode; 
                        Console.Write("◻︎"); 
                    }
                    EvenOdd *= -1;

                }
                if (number % 2 == 0)
                {
                    EvenOdd *= -1;
                }

                Console.WriteLine();
            }



        }
    }
}