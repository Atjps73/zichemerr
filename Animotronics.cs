using UnityEngine;

public class Animotronics : MonoBehaviour
{
    [SerializeField] private GameObject[] _animotronic = new GameObject[7];

    private readonly int _moveDelay = 10;
    private readonly int _nextIndex = 1;

    private int _index = -1;
    private int _index1 = 0;

    private void Start()
    {
        InvokeRepeating(nameof(Move), _moveDelay, 7);
    }

    private void Move()
    {
        _animotronic[_index].SetActive(false);
        _animotronic[_index1].SetActive(true);
        _index, _index1 += _nextIndex;
    }
}