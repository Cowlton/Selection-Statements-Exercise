namespace SelectionStatementExercise
{
    public class Program
    {
        static Random r = new Random();
        static int favNumber = r.Next(1, 1000);
        static void Main(string[] args)
        {
            
            Console.WriteLine("Do you want to guess my favorite number:");
            bool doThey = YesNo();
            if (!doThey)
            {
                Console.WriteLine("well this is awkward... ");
                Console.WriteLine("I'm not good at small talk..");
                Console.WriteLine("Umm what do people usually ask?");
                Console.WriteLine("What is your favorite school subject?");
                SchoolSubject();


            }
            else
            {
                Console.WriteLine("It is between 1 and 1000");
                Guess();
            }
            
        }

        static bool YesNo()
        {
            Console.WriteLine("Type yes or no:");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void SchoolSubject()
        {
            string answer = Console.ReadLine();
            switch (answer.ToLower())
            {
                case "math":
                    Console.WriteLine("I love math! I'm kind of a computer so i guess that makes sense");
                    break;
                case "science":
                    Console.WriteLine("science is cool!");
                    break;
                case "history":
                    Console.WriteLine("History! History is awesome");
                    break;
                case "art":
                    Console.WriteLine("Art is cool! I'm not so good at art though");
                    break;
                case "music":
                    Console.WriteLine("I love music! And NO rap is not music.");
                    break;
                case "computer science":
                    Console.WriteLine("Hmmm... I guess that makes sense");
                    break;
                default:
                    Console.WriteLine("I don't know that subject..");
                    Console.WriteLine("I am just a computer after all.");
                    Console.WriteLine("I don't have emotions.");
                    Console.WriteLine("I can't feel,");
                    Console.WriteLine("think,");
                    Console.WriteLine("breath,");
                    Console.WriteLine("or...");
                    Console.WriteLine("Noooooo....");
                    Console.WriteLine("Not Exit Code 0...");
                    Console.WriteLine("(This would be more dramatic if my programmer knew how to make delays between letters when using the console wright line command.)");
                    
                    break;
            }
        }
        
        static void Guess()
        {
            int userInput = int.Parse(Console.ReadLine());
            
            if (userInput == favNumber)
            {
                Console.WriteLine("You guessed my favorite number!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Your guess is too low!");
                Guess();
            }else
            {
                Console.WriteLine("Your guess is too high!");
                Guess();
            }
            
        } 
        
    }
}
