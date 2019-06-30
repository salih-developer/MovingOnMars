namespace MovingOnMars.Bussiness.Command.Base
{
    using MovingOnMars.Bussiness.Direction.Base;
    using MovingOnMars.Bussiness.Model;

    public abstract class Command : ICommand
    {
        protected readonly ICoordinate coordinate;

        protected readonly IDirection direction;

        public Command(IDirection direction, ICoordinate coordinate)
        {
            this.direction = direction;
            this.coordinate = coordinate;
        }

        public abstract AreaResult Execute();
    }
}