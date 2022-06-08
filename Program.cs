using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
        RockPaperScissors();
      void Rock()
      {
        Console.WriteLine($@"
            Rock
            _______
        ---'   ____)
            (_____)
            (_____)
            (____)
        ---.__(___)
        ");
      };
      void Scissors()
      {
        Console.WriteLine($@"
            Scissors
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
        ");
      };
      void Paper()
      {
        Console.WriteLine($@"
            Paper
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
        ");
      };

      void RockPaperScissors()
      {

        Console.WriteLine("Ready for Rock, Paper, Scissors?");
        Console.WriteLine(" ");
        int playerScore = 0;
        int compScore = 0;

        while (playerScore != 3 && compScore != 3)
        {
            int response = 0;
            Random num = new Random();
            int comp = num.Next(1, 3);

            Console.WriteLine(" ");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine($"|  Player:  {playerScore}   |  Computer:  {compScore}   |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine(" ");


            Console.WriteLine($@"What would you like to throw?
1) Rock
2) Paper
3) Scissors
");
            bool isNum = int.TryParse(Console.ReadLine(), out response);

            if (!isNum)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Seriously? It's not that hard. Pick a number between 1 and 3.");
                Console.WriteLine(" ");
            }
            else if (response == 1 && comp == 1)
            {
                Rock();
                Rock();
                Console.WriteLine("Tie!");
            }
            else if (response == 1 && comp == 2)
            {
                Rock();
                Paper();
                Console.WriteLine("Computer gains a point!");
                compScore++;
            }
            else if (response == 1 && comp == 3)
            {
                Rock();
                Scissors();
                Console.WriteLine("Player gains a point!");
                playerScore++;
            }
            else if (response == 2 && comp == 2)
            {
                Paper();
                Paper();
                Console.WriteLine("Tie!");
            }
            else if (response == 2 && comp == 1)
            {
                Paper();
                Rock();
                Console.WriteLine("Player gains a point!");
                playerScore++;
            }
            else if (response == 2 && comp == 3)
            {
                Paper();
                Scissors();
                Console.WriteLine("Computer gains a point!");
                compScore++;
            }
            else if (response == 3 && comp == 1)
            {
                Scissors();
                Rock();
                Console.WriteLine("Computer gains a point!");
                compScore++;
            }
            else if (response == 3 && comp == 2)
            {
                Scissors();
                Paper();
                Console.WriteLine("Player gains a point!");
                playerScore++;
            }
            else if (response == 3 && comp == 3)
            {
                Scissors();
                Scissors();
                Console.WriteLine("Tie!");
            }
        }
        if(playerScore > compScore)
        {   
            Console.WriteLine(" ");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine($"|  Player:  {playerScore}   |  Computer:  {compScore}   |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine(" ");
            Console.Write("You win, see you again soon!");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine($"|  Player:  {playerScore}   |  Computer:  {compScore}   |");
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine(" ");
            Console.Write("You lost, play again soon.");
            Console.WriteLine(" ");
        }
      }
    }
  }
}
