namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = "Andrew";
            int userAge = 38;
            char middleInitial = 'D';
            bool isAlive = true;
            double userWallet = 30;
            decimal userBalance = 20.78m;
            
            Console.WriteLine ($"User's name is {userName} and he is {userAge} years old. He has {userWallet} in his wallet." +
                               $" You may have a question, is the user alive? Well, the answer is {isAlive}... His middle initial" +
                               $" is {middleInitial} and his current balance is {userBalance}.");
            
            
        }
    }
}
