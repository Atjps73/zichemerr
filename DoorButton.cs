using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private YourMom _door;

    private readonly float _animationButton = 0.03f;

    private void Awake()
    {
        _position = transform.localPosition;
    }
    
    private void OnMouseDown()
    {
        transform.localPosition = _position - transform.forward * _animationButton;
        _door.ButtonPressed();
        Invoke(nameof(MouseUp), 0.1f);
    }
    
    private void MouseUp()
    {
        transform.localPosition = _position;
    }
}
