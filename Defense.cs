using UnityEngine;

public class Defense : MonoBehaviour
{
    [SerializeField] private GameObject _hareInDoor;
    [SerializeField] private GameObject _hareScreamer;
    [SerializeField] private GameObject _doorOpen;

    private readonly int _attackDelay = 5;

    private void Update()
    {
        if (_hareInDoor.activeSelf == true)
            Invoke(nameof(AttackDelay), _attackDelay);
    }
    private void AttackDelay()
    {
        if (_doorOpen.activeSelf == true)
        {
            Destroy(_hareInDoor);
            _hareScreamer.SetActive(true);
        }
    }
}
