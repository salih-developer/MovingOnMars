namespace MovingOnMars.Bussiness.Command
{
    using MovingOnMars.Bussiness.Command.Base;
    using MovingOnMars.Bussiness.Direction.Base;
    using MovingOnMars.Bussiness.Model;

    public class MoveCommand : Command
    {
        public MoveCommand(IDirection direction, ICoordinate coordinate)
            : base(direction, coordinate)
        {
        }

        public override AreaResult Execute()
        {
            return new AreaResult(this.direction, this.direction.Remapping(this.coordinate));
        }
    }
}