namespace MovingOnMars.Bussiness.Direction
{
    using MovingOnMars.Bussiness.Direction.Base;

    public class NorthDirection : IDirection
    {
        public char Direction => 'N';

        public IDirection Left()
        {
            return new WestDirection();
        }

        public ICoordinate Remapping(ICoordinate coordinate)
        {
            return new Coordinate(coordinate.X, coordinate.Y + 1);
        }

        public IDirection Right()
        {
            return new EastDirection();
        }
    }
}