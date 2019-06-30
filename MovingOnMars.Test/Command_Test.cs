namespace MovingOnMars.Test
{
    using FluentAssertions;

    using MovingOnMars.Bussiness;
    using MovingOnMars.Bussiness.Command;
    using MovingOnMars.Bussiness.Command.Base;
    using MovingOnMars.Bussiness.Direction;
    using MovingOnMars.Bussiness.Direction.Base;

    using NUnit.Framework;

    public class Command_Test
    {
        [TestCase(1, 3)]
        public void When_Given_Direction_and_Coordinates_Then_It_Should_LeftCommand_Execute(int x, int y)
        {
            ICoordinate coordinate = new Coordinate(x, y);
            IDirection direction = new EastDirection();
            ICommand command = new LeftCommand(direction, coordinate);
            var result = command.Execute();
            result.Should().NotBeNull();
            result.Coordinate.Should().NotBeNull();
            result.Direction.Should().NotBeNull();
        }
        [TestCase(2, 3)]
        public void When_Given_Direction_and_Coordinates_Then_It_Should_RightCommand_Execute(int x, int y)
        {
            ICoordinate coordinate = new Coordinate(x, y);
            IDirection direction = new EastDirection();
            ICommand command = new RightCommand(direction, coordinate);
            var result = command.Execute();
            result.Should().NotBeNull();
            result.Coordinate.Should().NotBeNull();
            result.Direction.Should().NotBeNull();
        }
        [TestCase(2, 3)]
        public void When_Given_Direction_and_Coordinates_Then_It_Should_MoveCommand_Execute(int x, int y)
        {
            ICoordinate coordinate = new Coordinate(x, y);
            IDirection direction = new EastDirection();
            ICommand command = new MoveCommand(direction, coordinate);
            var result = command.Execute();
            result.Should().NotBeNull();
            result.Coordinate.Should().NotBeNull();
            result.Direction.Should().NotBeNull();
        }
    }
}