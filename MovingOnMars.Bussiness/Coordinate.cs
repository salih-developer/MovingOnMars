namespace MovingOnMars.Bussiness
{
    public class Coordinate : ICoordinate
    {
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public override string ToString()
        {
            return $"x:{this.X} , x:{this.Y}";
        }
    }
}