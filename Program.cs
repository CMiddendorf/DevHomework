using System;
using System.Collections.Generic;

namespace DevHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting date outside of purchase for test purposes. Would preferably set date in Purchase constructor.
            DateTime date = DateTime.Now;
            DateTime date2 = date.AddMonths(1);
            DateTime date3 = date.AddMonths(2);

            // Building sample data
            User user = new User("Curtis", "Middendorf");
            Purchase purchase1 = new Purchase(120, date, user);
            Purchase purchase2 = new Purchase(78, date2, user);
            Purchase purchase3 = new Purchase(134, date2, user);
            Purchase purchase4 = new Purchase(49, date3, user);
            Purchase purchase5 = new Purchase(92, date3, user);
            Purchase purchase6 = new Purchase(200, date3, user);

            List<Purchase> userHistory = user.Purchases;

            // Going for a more direct method. Preferrably I would have a database storing date info giving me the ability to get data by month/year through a LINQ query.
            int monthRewards = 0;
            int monthRewards2 = 0;
            int monthRewards3 = 0;

            for (int i = 0; i < userHistory.Count; i++){
                int purchaseMonth = userHistory[i].Date.Month;
                if (purchaseMonth == date.Month)
                {
                    monthRewards += userHistory[i].Reward.Points;
                }
                if (purchaseMonth == date2.Month)
                {
                    monthRewards2 += userHistory[i].Reward.Points;
                }
                if (purchaseMonth == date3.Month)
                {
                    monthRewards3 += userHistory[i].Reward.Points;
                }
            }

            int totalRewards = monthRewards + monthRewards2 + monthRewards3;

            Console.WriteLine("Rewards for {0}, {1}", user.LastName, user.FirstName);
            Console.WriteLine("Month 1 Rewards: {0}", monthRewards);
            Console.WriteLine("Month 2 Rewards: {0}", monthRewards2);
            Console.WriteLine("Month 3 Rewards: {0}", monthRewards3);
            Console.WriteLine("Total Rewards: {0}", totalRewards);

            //// Individual Checks
            //Console.WriteLine(purchase1.Reward.Points);
            //Console.WriteLine(purchase2.Reward.Points);
            //Console.WriteLine(purchase3.Reward.Points);
            //Console.WriteLine(purchase4.Reward.Points);
            //Console.WriteLine(purchase5.Reward.Points);
            //Console.WriteLine(purchase6.Reward.Points);
        }
    }
}
