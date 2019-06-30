namespace MovingOnMars.Test
{
    using FluentAssertions;

    using MovingOnMars.Bussiness;

    using NUnit.Framework;

    public class GridArea_Test
    {
        [TestCase(1, 3, 1, 3)]
        public void When_Given_Coordinates_Then_It_Should_Create_Area(int x, int y, int inx, int iny)
        {
            var area = new GridArea(x, y);
            area.Should().NotBe(null);
            area.Width.Should().Be(inx);
            area.Height.Should().Be(iny);
        }
    }
}