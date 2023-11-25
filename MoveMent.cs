using UnityEngine;

public class MoveMent : MonoBehaviour
{
    [SerializeField] private GameObject[] _animotronic = new GameObject[7];

    private readonly int _moveDelayPosition1 = 50;
    private readonly int _moveDelay = 10;

    private void Start()
    {
        Invoke(nameof(MovementAnimotronicN1), _moveDelayPosition1);
    }

    private void MovementAnimotronic(GameObject[] _animotronic, int index, int index1, string method)
    {
        _animotronic[index].SetActive(false);
        _animotronic[index1].SetActive(true);
        Invoke(method, _moveDelay);
    }

    private void MovementAnimotronicN1()
    {
        MovementAnimotronic(_animotronic, 0, 1, "MovementAnimotronicN2");
    }

    private void MovementAnimotronicN2()
    {
        MovementAnimotronic(_animotronic, 1, 2, "MovementAnimotronicN3");
        _animotronic[6].SetActive(false);
    }

    private void MovementAnimotronicN3()
    {
        MovementAnimotronic(_animotronic, 2, 3, "MovementAnimotronicN4");
    }

    private void MovementAnimotronicN4()
    {
        MovementAnimotronic(_animotronic, 3, 4, "MovementAnimotronicN5");
    }

    private void MovementAnimotronicN5()
    {
        MovementAnimotronic(_animotronic, 4, 5, "MovementAnimotronicN6");
    }

    private void MovementAnimotronicN6()
    {
        MovementAnimotronic(_animotronic, 5, 6, "MovementAnimotronicN2");
    }
}
