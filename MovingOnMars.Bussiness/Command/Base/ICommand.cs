namespace MovingOnMars.Bussiness.Command.Base
{
    using MovingOnMars.Bussiness.Model;

    public interface ICommand
    {
        AreaResult Execute();
    }
}