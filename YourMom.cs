using UnityEngine;

public class YourMom: MonoBehaviour
{
    [SerializeField] private Vector3 _openPosition;
    [SerializeField] private Vector3 _closePosition;
    [SerializeField] private Vector3 _NextPosition;
    [SerializeField] private GameObject[] obj = new GameObject[3];

    private bool _isOpen = true;
    private bool _action = false;
    private readonly int _speed = 12;

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
            {
                obj[1].SetActive(true);
                obj[0].SetActive(false);
            }
        }
        else
        {
            _NextPosition = _closePosition;
            {
                obj[0].SetActive(true);
                obj[1].SetActive(false);
            }
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
    






