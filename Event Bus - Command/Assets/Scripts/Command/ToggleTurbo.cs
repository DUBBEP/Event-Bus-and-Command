public class ToggleTurbo : Command
{
    private BikeControllerCommand _controller;

    public ToggleTurbo(BikeControllerCommand controller)
    {
        _controller = controller;
    }

    public override void Execute()
    {
        _controller.ToggleTurbo();
    }
}
