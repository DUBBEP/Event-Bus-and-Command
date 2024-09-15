public class TurnLeft : Command
{
    private BikeControllerCommand _controller;
    
    public TurnLeft(BikeControllerCommand controller)
    {
        _controller = controller;
    }

    public override void Execute()
    {
        _controller.Turn(BikeControllerCommand.Direction.Left);
    }
}
