namespace MovingOnMars.Bussiness.Direction.Base
{
    using System;

    public interface IDirection
    {
        char Direction { get; }

        ICoordinate Remapping(ICoordinate coordinate);

        IDirection Left();
        IDirection Right();
    }
}