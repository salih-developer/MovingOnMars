namespace MovingOnMars.Test
{
    using FluentAssertions;

    using MovingOnMars.Bussiness;
    using MovingOnMars.Bussiness.Direction;
    using MovingOnMars.Bussiness.Direction.Base;

    using NUnit.Framework;

    public class Direction_Test
    {
        [TestCase(1, 3, 2)]
        public void When_Given_Coordinates_Then_It_Should_Remapping_EastDirection(int x, int y, int calc)
        {
            IDirection direction = new EastDirection();
            var result = direction.Remapping(new Coordinate(x, y));
            result.X.Should().Be(calc);
        }

        [TestCase(1, 3, 4)]
        public void When_Given_Coordinates_Then_It_Should_Remapping_NorthDirection(int x, int y, int calc)
        {
            IDirection direction = new NorthDirection();
            var result = direction.Remapping(new Coordinate(x, y));
            result.Y.Should().Be(calc);
        }

        [TestCase(1, 2, 1)]
        public void When_Given_Coordinates_Then_It_Should_Remapping_SouthDirection(int x, int y, int calc)
        {
            IDirection direction = new SouthDirection();
            var result = direction.Remapping(new Coordinate(x, y));
            result.Y.Should().Be(calc);
        }

        [TestCase(2, 3, 1)]
        public void When_Given_Coordinates_Then_It_Should_Remapping_WestDirection(int x, int y, int calc)
        {
            IDirection direction = new WestDirection();
            var result = direction.Remapping(new Coordinate(x, y));
            result.X.Should().Be(calc);
        }

        [TestCase(5, 4)]
        public void When_Given_X_Y_Then_It_Should_Create_Coordinate(int x, int y)
        {
            ICoordinate coordinate = new Coordinate(x, y);
            coordinate.Should().NotBe(null);
        }
    }
}