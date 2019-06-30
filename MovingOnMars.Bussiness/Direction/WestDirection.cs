namespace MovingOnMars.Bussiness.Direction
{
    using MovingOnMars.Bussiness.Direction.Base;

    public class WestDirection : IDirection
    {
        public char Direction => 'W';

        public IDirection Left()
        {
            return new SouthDirection();
        }

        public ICoordinate Remapping(ICoordinate coordinate)
        {
            return new Coordinate(coordinate.X - 1, coordinate.Y);
        }

        public IDirection Right()
        {
            return new NorthDirection();
        }
    }
}