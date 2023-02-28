using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class Button : MonoBehaviour
{
    [SerializeField]
    private XRLever _lever;
    [SerializeField]
    private XRPushButton _pushButton;

    private void OnEnable()
    {
        _lever.onLeverActivate.AddListener(Activate);
        _lever.onLeverDeactivate.AddListener(Deactivate);

        _pushButton.onPress.AddListener(Activate);
        _pushButton.onRelease.AddListener(Deactivate);
    }
    private void OnDisable()
    {
        _lever.onLeverActivate.RemoveListener(Activate);
        _lever.onLeverDeactivate.RemoveListener(Deactivate);

        _pushButton.onPress.RemoveListener(Activate);
        _pushButton.onRelease.RemoveListener(Deactivate);
    }
    public void Activate()
    {
        Debug.Log("Activate");
    }
    public void Deactivate()
    {
        Debug.Log("Deactivate");
    }
}
