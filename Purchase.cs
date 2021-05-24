using System;

namespace DevHomework
{
    class Purchase
    {
        private int amount;
        private DateTime date;
        private Rewards reward;

        public int Amount
        {
            get
            {
                return amount;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
        }
        public Rewards Reward
        {
            get
            {
                return reward;
            }
        }

        public Purchase(int amount, DateTime date, User consumer)
        {
            // Set basic purchase data
            this.amount = amount;
            this.date = date;

            // Generate reward points
            reward = new Rewards(amount);

            // Add purchase to user history
            consumer.AddPurchase(this);
        }
    }
}
