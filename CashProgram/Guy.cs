using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashProgram
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        /// <sumary>
        /// 
        /// Writes my name and how much I have into the console.
        /// 
        /// </sumary>

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + "has" + Cash + "bucks.");
        }
        /// <summary>
        /// Give part of my money, taking it from my wallet (or writing a message on the console if I don't have enough money).
        /// </summary>
        /// <param name="amount">Amount of money to be delivered.</param>
        /// <returns>
        /// The amount of money withdraw from my wallet or 0 if I dont't have enough money (or if the amount is unavailable).
        /// </returns>


    public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + "says: " + amount + "isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + "says: " + "I don't have enough cash to give you" + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Receive some money, adding it to my wallet (or  writing a message on the console if the amount is unavailable.
        /// </summary>
        /// <param name="amount">Amount of money to give.</param>
    public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + "says: " + amount + "isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
