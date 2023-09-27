namespace Kabatra.Game.Dice
{
    /// <summary>
    ///     Avoid creating multiple instances to improve performance.
    /// </summary>
    public class Dice
    {
        readonly Random randomGenerator;

        public Dice() 
        {
            randomGenerator = new Random();
        }

        public int RollSingleDice(Shape shape)
        {
            return randomGenerator.Next(1, (int)shape);
        }
        
        public IEnumerable<int> RollingMultipleDice(Shape shape, int numberOfDice)
        {
            List<int> diceResults = new List<int>();
            for(var iterator = 0; iterator < numberOfDice; iterator++)
            {
                diceResults.Add(randomGenerator.Next(1, (int) shape));
            }

            return diceResults;
        }
    }
}