using System;

namespace MovingOnMars.Bussiness
{
    public class GridArea
    {
        private readonly int width;

        private readonly int height;

        public GridArea(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
        }

        public bool ValidPosition(ICoordinate coordinate)
        {
            return coordinate.X <= this.width && coordinate.Y <= this.height;
        }
    }
}