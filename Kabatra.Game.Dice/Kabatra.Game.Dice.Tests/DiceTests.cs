namespace Kabatra.Game.Dice.Tests
{
    public class DiceTests
    {
        [Theory]
        [InlineData(Shape.D4)]
        [InlineData(Shape.D6)]
        [InlineData(Shape.D8)]
        [InlineData(Shape.D10)]
        [InlineData(Shape.D12)]
        [InlineData(Shape.D20)]
        public void CanRollSingleDice(Shape shape)
        {
            var dice = new Dice();
            var result = dice.RollSingleDice(shape);
            
            Assert.NotEqual(0, result);
            Assert.InRange(result, 1, (int) shape);
        }

        [Theory]
        [InlineData(Shape.D4, 2)]
        [InlineData(Shape.D6, 2)]
        [InlineData(Shape.D8, 2)]
        [InlineData(Shape.D10, 2)]
        [InlineData(Shape.D12, 2)]
        [InlineData(Shape.D20, 2)]
        public void CanRollMultipleDice(Shape shape, int numberOfDice)
        {
            var dice = new Dice();
            var results = dice.RollingMultipleDice(shape, numberOfDice).ToList();
            
            Assert.Equal(numberOfDice, results.Count);
            results.ForEach(result => {
                Assert.NotEqual(0, result);
                Assert.InRange(result, 1, (int)shape);
            });
        }
    }
}
