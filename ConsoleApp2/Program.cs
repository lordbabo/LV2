using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            Random randomGenerator = new Random();
            int i;
            int numOfDice = 20;
            for(i=0;i<numOfDice; i++)
            {
                diceRoller.InsertDie(new Die(6)); //zadatak 1
                diceRoller.InsertDie(new Die(6, randomGenerator)); //zadatak 2

            }
            IList<int> resultsOfRolling = diceRoller.GetRollingResults();
            diceRoller.RollAllDice();
            foreach (int result in resultsOfRolling)
            {
                Console.WriteLine(result);
            }
        }
    }
}
