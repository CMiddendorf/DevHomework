namespace DevHomework
{
    class Rewards
    {
        int points = 0;
        public int Points
        {
            get
            {
                return points;
            }
        }

        public Rewards (int amount)
        {
            if (amount > 50)
            {
                // Remove the limit that was reached.
                int newAmount = amount - 50;

                // If the excess is greater than 50, break off at 50 points then give 2 points per the new excess.
                if (newAmount > 50)
                {
                    points += 50;
                    newAmount -= 50;
                    points += (newAmount * 2);
                }
                // Add points based on excess.
                else
                {
                    points += newAmount;
                }
            }
        }
    }
}
