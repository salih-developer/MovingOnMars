using MovingOnMars.Bussiness.Direction.Base;

namespace MovingOnMars.Bussiness.Model
{
    public class AreaResult
    {
        public AreaResult(IDirection direction, ICoordinate coordinate)
        {
            this.Direction = direction;
            this.Coordinate = coordinate;
        }

        public ICoordinate Coordinate { get; }

        public IDirection Direction { get; }

        public override string ToString()
        {
            return $"{Coordinate.X} {Coordinate.Y} {Direction.Direction}";
        }
    }
}