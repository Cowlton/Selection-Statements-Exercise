namespace SelectionStatementExercise
{
    public class Program
    {
        static Random r = new Random();
        static int favNumber = r.Next(1, 1000);
        static void Main(string[] args)
        {
            
            Console.WriteLine("Guess my favorite number:");
            Console.WriteLine("It is between 1 and 1000");
            guess();

        }

        static void guess()
        {
            int userInput = int.Parse(Console.ReadLine());
            
            if (userInput == favNumber)
            {
                Console.WriteLine("You guessed my favorite number!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Your guess is too low!");
                guess();
            }else
            {
                Console.WriteLine("Your guess is too high!");
                guess();
            }
            
        } 
        
    }
}
