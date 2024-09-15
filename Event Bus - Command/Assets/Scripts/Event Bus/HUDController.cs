using UnityEngine;

public class HUDController : MonoBehaviour
{
    private bool _isDisplayOn;

    private void OnEnable()
    {
        RaceEventBus.Subscribe(
            RaceEventType.START, DisplayHud);
    }

    private void OnDisable()
    {
        RaceEventBus.Unsubscribe(
            RaceEventType.START, DisplayHud);
    }

    private void DisplayHud()
    {
        _isDisplayOn = true;
    }

    private void OnGUI()
    {
        if (_isDisplayOn)
        {
            if (GUILayout.Button("Stop Race"))
            {
                _isDisplayOn = false;
                RaceEventBus.Publish(RaceEventType.STOP);
            }
        }
    }
}
