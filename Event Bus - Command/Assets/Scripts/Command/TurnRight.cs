public class TurnRight : Command
{
    private BikeControllerCommand _controller;
    
    public TurnRight(BikeControllerCommand controller)
    {
        _controller = controller;
    }

    public override void Execute()
    {
        _controller.Turn(BikeControllerCommand.Direction.Right);
    }
}
