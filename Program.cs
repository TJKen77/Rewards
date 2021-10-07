using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rewards
{
    class Program
    {
        static void Main(string[] args)
        {
            string cust1Purchases = "120";
            string cust2Purchases = "120, 120, 120";
            string cust3Purchases = "55, 55, 101, 68";
            string cust4Purchases = "1023, 1233, 1000";
            string cust5Purchases = "12, 21, 15, 8";

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Welcome to the Rewards Program"); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Don's purchases were: " + cust1Purchases + ". \n\r \tDon earned " + CalcRewards(cust1Purchases) + " rewards points.\n\r");
            Console.WriteLine("Chris's purchases were: " + cust2Purchases + ". \n\r \tChris earned " + CalcRewards(cust2Purchases) + " rewards points.\n\r");
            Console.WriteLine("Sally purchases were: " + cust3Purchases + ". \n\r \tSally earned " + CalcRewards(cust3Purchases) + " rewards points.\n\r");
            Console.WriteLine("Olgamaria's purchases were: " + cust4Purchases + ". \n\r \tOlgamaria earned " + CalcRewards(cust4Purchases) + " rewards points.\n\r");
            Console.WriteLine("Jim's purchases were: " + cust5Purchases + ". \n\r \tJim earned " + CalcRewards(cust5Purchases) + " rewards points.\n\r");
            Console.WriteLine();

            int rewards = 0;
            Console.WriteLine("Enter your own dataset (comma seperated integers): ");
            string data = Console.ReadLine();
            rewards = CalcRewards(data);
            Console.WriteLine("You have earned " + rewards.ToString() + " rewards points.");
            Console.ReadKey();
        }

        public static int CalcRewards(string purchases)
        {
            int rewards = 0;

            foreach (string purchase in purchases.Split(','))
            {
                try
                {
                    int newpurchase = Convert.ToInt32(purchase);
                    if (newpurchase > 100)
                        rewards += 50 + ((newpurchase - 100) * 2);
                    else if (newpurchase > 50)
                        rewards += (newpurchase - 50);

                }
                catch(Exception ex)
                {
                    //ignore any messages for this app
                }
            }

            return rewards;
        }
    }
}
