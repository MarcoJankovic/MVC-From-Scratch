namespace MVC_From_Scratch.Models
{
    public class GuessGameNr
    {
        public static string MatchGuess(int guess, int rnd)
        {
            if (guess < rnd)
            {
                return "Higher... stupid!!";
            }
            else if (guess > rnd)
            {
                return "Lower OMG how low do you have to go ?";
            }
            else
            {
                return "Yo... you cheating!!, Gz..";
            }
        }

        public static int GetRandom(int max)
        {
            Random random = new Random();
            return random.Next(max);

        }
    }

}
