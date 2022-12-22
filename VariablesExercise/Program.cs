namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myString = "Blue Dog";
            int myInt = 29;
            char myChar = 'J';
            bool myStatus = false;
            double myDouble = 13.5;
            decimal myDecimal = 57.89m;

            Console.WriteLine($"The {myString} ran {myInt} miles to jump on the {myChar}.");
            Console.WriteLine($"I wondered if the story was {myStatus}, but the double was {myDouble}.");
            Console.WriteLine($"It wasn't {myStatus} --the decimal was {myDecimal}.");

        }
    }
}
