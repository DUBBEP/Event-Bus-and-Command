using UnityEngine;


public class BikeControllerBus : MonoBehaviour
{
    private string _status;

    void OnEnable()
    {
        RaceEventBus.Subscribe(
            RaceEventType.START, StartBike);

        RaceEventBus.Subscribe(
            RaceEventType.STOP, StopBike);
    }

    private void OnDisable()
    {
        RaceEventBus.Unsubscribe(
            RaceEventType.START, StartBike);

        RaceEventBus.Unsubscribe(
            RaceEventType.STOP, StopBike);
    }

    private void StartBike()
    {
        _status = "Started";
    }

    private void StopBike()
    {
        _status = "Stopped";
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(
            new Rect(10, 60, 200, 20),
            "BIKE STATUS: " + _status);
    }
}
