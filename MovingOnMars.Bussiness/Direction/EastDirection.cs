namespace MovingOnMars.Bussiness.Direction
{
    using MovingOnMars.Bussiness.Direction.Base;

    public class EastDirection : IDirection
    {
        public char Direction => 'E';

        public IDirection Left()
        {
            return new NorthDirection();
        }

        public ICoordinate Remapping(ICoordinate coordinate)
        {
            return new Coordinate(coordinate.X + 1, coordinate.Y);
        }

        public IDirection Right()
        {
            return new SouthDirection();
        }
    }
}