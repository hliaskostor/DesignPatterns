using System;
class Program
{
    public abstract class BasketGame
    {
        public abstract void game();
    }

    public class Players : BasketGame
    {
        public override void game()
        {
            Console.WriteLine("5 players in each team");
        }
    }

    public class Referee : BasketGame
    {
        public override void game()
        {
            Console.WriteLine("3 referees");
        }
    }

    public class Coach : BasketGame
    {
        public override void game()
        {
            Console.WriteLine("Play defense");
        }
    }

    static void Main(string[] args)
    {
        BasketGame players = new Players();
        players.game();

        BasketGame referee = new Referee();
        referee.game();

        BasketGame coach = new Coach();
        coach.game();

    }
}
