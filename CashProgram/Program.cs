namespace CashProgram

{
    internal class Program
    {

        static void Main(string[] args)
        {
            Guy joe = new Guy()
            {
                Cash = 50,
                Name = "Joe"
            };

            Guy bob = new Guy()
            {
                Cash = 100,
                Name = "Bob"
            };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.WriteLine("Enter an amount: ");

                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                
                if (int .TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("who should give the cash: ");
                    string whichGuy = Console.ReadLine(); 
                    if (whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }

                        else if (whichGuy == "Bob")
                        {
                            int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                        }
                    else
                    {
                        Console.WriteLine("Please, enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please, enter an amount (or an blank line to exit).");
                }
            }
        }
    }
}
