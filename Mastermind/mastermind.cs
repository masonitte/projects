using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
  public class Mastermind
  {
    public Mastermind()
    {

    }
    public void GenerateRandomNumber()
    {
      Random num = new Random();
      var dig1 = num.Next(1, 7);
      var dig2 = num.Next(1, 7);
      var dig3 = num.Next(1, 7);
      var dig4 = num.Next(1, 7);

      var randomNum = (dig1.ToString() + dig2.ToString() + dig3.ToString() + dig4.ToString());
      //Console.WriteLine("The numBer is: " + randomNum);
      Play(randomNum);
      return;
    }

    public void Play(string randomNum)
    {
      int guesses = 10;
      while (guesses > 0)
      {
        try
        {
          Console.WriteLine("Guess a 4 digit number. Each digit must be 6 or lower.");
          var guessedNum = Console.ReadLine();
          if (guessedNum.Length != 4)
          {
            Console.WriteLine("Your guess must be 4 digits long");
            break;
          }
          guesses--;
          Console.WriteLine("You have " + guesses + " guesses remaining.");
          var correct = "";
          var incorrect = "";

          for (int i = 0; i < guessedNum.Length; i++)
          {
            if (guessedNum[i] == randomNum[i])
            {
              correct += "+";
            }
            else if (guessedNum[i] != randomNum[i])
            {
              for (int j = i + 1; j < randomNum.Length; j++)
              {
                if (guessedNum[i] == randomNum[j])
                {
                  incorrect += "-";
                }

              }
            }
            else { }
          }
          var hint = correct + incorrect;
          Console.WriteLine(hint);
          if (hint.Equals("++++"))
          {
            Console.WriteLine("gratz dawg u win");
            break;
          }

        }
        catch (Exception e)
        {
          Console.WriteLine(e);
        }
      }
      Console.WriteLine("The numBer is: " + randomNum);
      Console.WriteLine("Press enter to exit");
      Console.ReadLine();

    }

  }
}

