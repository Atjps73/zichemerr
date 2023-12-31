using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Vector3 _openPosition;
    [SerializeField] private Vector3 _closePosition;
    [SerializeField] private Vector3 _NextPosition;
    [SerializeField] private GameObject[] obj = new GameObject[3];

    private readonly int _speed = 12;
    
    private bool _isOpen = true;
    private bool _action = false;

    internal void ButtonPressed()
    {
        _isOpen = !_isOpen;
        _action = true;
    }
    
    private void Update()
    {
        if (_isOpen)
        {
            _NextPosition = _openPosition;
        }
        else
        {
            _NextPosition = _closePosition;
        }
        if (_action)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, _NextPosition, _speed * Time.deltaTime);

            if (Vector3.Distance(transform.localPosition, _NextPosition) < 0.01f)
            {
                transform.localPosition = _NextPosition;
                _action = false;
            }
        }
    }
}
    






