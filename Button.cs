using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject _doorLight;

    private Vector3 _position;
    private readonly float _animationButton = -0.03f;

    private void Awake()
    {
        _position = transform.localPosition;
    }
    private void OnMouseDown()
    {
        transform.localPosition = _position - transform.forward * _animationButton;
        _doorLight.SetActive(true);
    }
    private void OnMouseUp()
    {
        transform.localPosition = _position;
        _doorLight.SetActive(false);
    }
}
