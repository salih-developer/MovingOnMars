namespace MovingOnMars.Bussiness.Direction
{
    using MovingOnMars.Bussiness.Direction.Base;

    public class SouthDirection : IDirection
    {
        public char Direction => 'S';

        public IDirection Left()
        {
            return new EastDirection();
        }

        public ICoordinate Remapping(ICoordinate coordinate)
        {
            return new Coordinate(coordinate.X, coordinate.Y - 1);
        }

        public IDirection Right()
        {
            return new WestDirection();
        }
    }
}