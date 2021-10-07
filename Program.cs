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
            int rewards = 0;
            Console.WriteLine("Enter the dataset: ");
            string data = Console.ReadLine();
            foreach(string purchase in data.Split(','))
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
            Console.WriteLine("You have earned " + rewards.ToString() + " rewards points.");
            Console.ReadKey();
        }
    }
}
